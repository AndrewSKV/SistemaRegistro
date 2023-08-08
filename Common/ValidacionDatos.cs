using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Common
{
    internal class ValidacionDatos
    {
        public static bool EsNumeroEnteroPositivo(string texto)
        {
            if (long.TryParse(texto, out long numero))
            {
                return numero > 0;
            }
            return false;
        }

        public static bool NoContieneNumeros(string texto)
        {
            foreach (char caracter in texto)
            {
                if (char.IsDigit(caracter))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsCampoVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        public static bool ValidarEdad(string edad)
        {
            if (EsCampoVacio(edad))
            {
                return false;
            }

            return EsNumeroEnteroPositivo(edad);
        }

        public static bool ValidarDocumento(string numeroDocumento)
        {
            if (EsCampoVacio(numeroDocumento))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarPrimerNombre(string primerNombre)
        {
            if (EsCampoVacio(primerNombre))
            {
                return false;
            }

            return NoContieneNumeros(primerNombre);
        }

        public static bool ValidarPrimerApellido(string primerApellido)
        {
            if (EsCampoVacio(primerApellido))
            {
                return false;
            }

            return NoContieneNumeros(primerApellido);
        }

        public static bool ValidarDireccion(string direccion)
        {
            return !EsCampoVacio(direccion);
        }

        public static bool ValidarGenero(string genero)
        {
            if (EsCampoVacio(genero))
            {
                return false;
            }

            return NoContieneNumeros(genero);
        }
    }
}
