using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Security;

namespace SistemaRegistro.Common
{
    public class DatabaseManager : IDisposable
    {
        private readonly string connectionString;
        private SQLiteConnection connection;

        public static string RutaDB { get; set; } = Path.Combine(Application.StartupPath, "SistemaRegistro.db");

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
            return ExecuteNonQuery(consultaInsert, parametros);


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

        public bool VerificarUsuario(string Usuario)
        {
            string query = "SELECT * FROM VistaUsuariosConRoles WHERE User = @Usuario";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@Usuario", Usuario)
            };

            DataTable dataTable = new DataTable();
            dataTable = ExecuteQueryWithParameters(query, parametros);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }


        }

        public bool VerificarPassword(string Password)
        {
            string query = "SELECT * FROM VistaUsuariosConRoles WHERE Password = @Password";
            string hash;

            //Convertir contraseña a SHA256 hash
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] hashPassword = sHA256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashPassword)
                {
                    sb.Append(b.ToString("x2"));
                }
                hash = sb.ToString();

            }

            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@Password", hash)
            };

            DataTable dataTable = new DataTable();
            dataTable = ExecuteQueryWithParameters(query, parametros);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool ActualizarRegistro(string ColumnName, string nuevoValor, string ID)
        {
            string updateQuery = $"UPDATE Personas SET {ColumnName} = @NuevoValor WHERE Documento = @ID";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@NuevoValor", nuevoValor),
                    new SQLiteParameter("@ID", ID)
            };

            return ExecuteNonQuery(updateQuery, parametros);
        }

        public bool IngresarNuevoUsuario(string Username, string Password, string Role)
        {
            string hash;

            //Convertir contraseña a SHA256 hash
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] hashPassword = sHA256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashPassword)
                {
                    sb.Append(b.ToString("x2"));
                }
                hash = sb.ToString();

            }

            //Ejecutar INSERT en Usuarios
            string query = "INSERT INTO Usuarios (User, Password) VALUES (@Usuario, @Password)";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@Usuario", Username),
                    new SQLiteParameter("@Password", hash),
            };
            bool InsertUsuarioRolExitoso;
            bool InsertUsuarioExitoso = ExecuteNonQuery(query, parametros);

            if (InsertUsuarioExitoso)
            {
                //Tomar el ID del nuevo Usuario
                query = "SELECT ID FROM Usuarios WHERE User = @Usuario";
                DataTable dtUserID = ExecuteQueryWithParameters(query, parametros);

                //Insertar relación Usuario-Rol en la tabla UsuariosRoles
                query = "INSERT INTO UsuariosRoles (IDUser, IDRol) VALUES (@IDUser, @IDRol)";
                parametros = new SQLiteParameter[]
                {
                    new SQLiteParameter("@IDUser", dtUserID.Rows[0][0].ToString),
                    new SQLiteParameter("@IDRol", Role),
                };
                InsertUsuarioRolExitoso = ExecuteNonQuery(query, parametros);
            }
            else
            {
                return false;
            }

            return InsertUsuarioExitoso & InsertUsuarioRolExitoso;

        }

        public bool EliminarRegistro(string Documento)
        {
            string query = "DELETE FROM Personas WHERE Documento = @Documento";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@Documento", Documento)
            };

            return ExecuteNonQuery(query, parametros);
        }

        public string ObtenerRolUsuario(string User)
        {
            string query = "SELECT IDRol FROM VistaUsuariosConRoles WHERE User = @User";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                    new SQLiteParameter("@User", User)
            };

            DataTable dataTable = ExecuteQueryWithParameters(query, parametros);
            return dataTable.Rows[0][0].ToString();
        }
    }
}
