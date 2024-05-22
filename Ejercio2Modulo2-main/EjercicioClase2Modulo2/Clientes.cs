using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2Modulo2
{
    internal class Clientes
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Vip { get; set; }

        public string ClienteTipo(bool verEstdo)// no me deja hacer el cabio por el tipo de datos de bool a string
        {
            if (verEstdo)
            {
                return "premium";
            }
            else
            {
                return "normal";
            }
        }
    }
}
