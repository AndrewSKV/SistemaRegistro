using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Common
{
    public class Persona
    {
        public Persona(string numeroDocumento, string primerNombre, string primerApellido, string? segundoNombre, string? segundoApellido, string? telefono, string? correo, string direccion, int edad, string genero)
        {
            NumeroDocumento = numeroDocumento;
            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            SegundoNombre = segundoNombre;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
        }

        public string NumeroDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoNombre { get; set; }
        public string? SegundoApellido { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
    }

}
