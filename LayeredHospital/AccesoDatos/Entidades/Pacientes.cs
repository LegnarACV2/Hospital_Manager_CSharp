using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Pacientes
    {
        public int id_Paciente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Asegurado { get; set; }
    }
}
