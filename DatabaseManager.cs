using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaRegistro
{
    public class DatabaseManager : IDisposable
    {
        private readonly string connectionString;
        private SQLiteConnection connection;

        public static string RutaDB { get; set; } = "D:\\SQLite\\bds\\SistemaRegistro.db";

        public DatabaseManager(string dbFilePath)
        {
            connectionString = $"Data Source={dbFilePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public DataTable ExecuteQueryWithParameters(string query, params SQLiteParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    // Asignar los parámetros a la consulta
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    OpenConnection();
                    using (SQLiteDataReader dataReader = command.ExecuteReader())
                    {
                        dataTable.Load(dataReader);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores                   
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }

            }
            CloseConnection();
            return dataTable;
        }

        public bool ExecuteNonQuery(string query, SQLiteParameter[] parameters)
        {
            OpenConnection();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    // Agregar parámetros si los hay
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    CloseConnection();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    CloseConnection();
                    return false;
                }
            }
        }


        public DataTable GetAllRecords()
        {
            OpenConnection();
            string query = "SELECT * FROM Personas;";
            CloseConnection();
            return ExecuteQueryWithParameters(query);
            
        }

        public void Dispose()
        {
            connection.Dispose();
        }

        public bool InsertarPersona(Persona nuevaPersona)
        {
            // Consulta INSERT con parámetros. Los nombres de los parámetros deben coincidir con los nombres de las columnas en la tabla.
            string consultaInsert = @"INSERT INTO Personas (Documento, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Direccion, Edad, Genero) VALUES (@NumeroDocumento, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Telefono, @Correo, @Direccion, @Edad, @Genero)";

            // Lista de parámetros con los valores de nuevaPersona
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@NumeroDocumento", nuevaPersona.NumeroDocumento),
                new SQLiteParameter("@PrimerNombre", nuevaPersona.PrimerNombre),
                new SQLiteParameter("@PrimerApellido", nuevaPersona.PrimerApellido),
                new SQLiteParameter("@SegundoNombre", nuevaPersona.SegundoNombre),
                new SQLiteParameter("@SegundoApellido", nuevaPersona.SegundoApellido),
                new SQLiteParameter("@Telefono", nuevaPersona.Telefono),
                new SQLiteParameter("@Correo", nuevaPersona.Correo),
                new SQLiteParameter("@Direccion", nuevaPersona.Direccion),
                new SQLiteParameter("@Edad", nuevaPersona.Edad),
                new SQLiteParameter("@Genero", nuevaPersona.Genero)
            };

            // Ejecutar el INSERT
            if (ExecuteNonQuery(consultaInsert, parametros))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
            
        }

        public DataTable BuscarPersonasPorDocumentos(string numerosDocumento)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(numerosDocumento))
            {
                return dataTable; // DataTable vacío si no se proporcionan documentos
            }

            string query = $"SELECT * FROM Personas WHERE Documento IN ({numerosDocumento.Trim()})";          
            return ExecuteQueryWithParameters(query);
        }

        public bool ValidarDocumentoExistente(string numeroDocumento)
        {
            string query = "SELECT * FROM Personas WHERE Documento = @Documento";

            SQLiteParameter[] parametros = new SQLiteParameter[]
                 {
                    new SQLiteParameter("@Documento", numeroDocumento)
                 };

            DataTable dataTable = new DataTable();
            dataTable = ExecuteQueryWithParameters(query, parametros);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
