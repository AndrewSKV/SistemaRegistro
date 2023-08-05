using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaRegistro
{
    public class Tests
    {
        public void RealizarInsercion()
        {
            Persona nuevaPersona = new Persona(
                       "1000206906",
                       "Andrey",
                       "Suescun",
                       "",
                       "",
                       "3054045039",
                       "andrey.suescun@gmail.com",
                       "Cra 32 #49-105",
                       int.Parse("22"), // Aquí asumimos que la validación de edad fue exitosa, así que podemos convertir el texto a int
                       "Hombre"
                       );
            // Insertar la nueva persona en la base de datos
            DatabaseManager databaseManager = new DatabaseManager("D:\\SQLite\\bds\\SistemaRegistro.db"); // Pasar la conexión como argumento al constructor
            databaseManager.InsertarPersona(nuevaPersona);
        }
    }
}
