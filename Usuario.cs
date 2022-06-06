using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Usuario
    {
        public Usuario(string ci, string nombreCompleto)
        {
            Ci = ci;
            NombreCompleto = nombreCompleto;
        }
        public string Ci { get; set; }
        public string NombreCompleto { get; set; }
    }
}
