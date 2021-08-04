using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Citas
    {
        public int Id_Cita { get; set; }
        public DateTime Fecha { get; set; }
        public string Id_Paciente_C { get; set; }
        public string Id_Doctor_C { get; set; }
        public string Hora { get; set; }
    }
}
