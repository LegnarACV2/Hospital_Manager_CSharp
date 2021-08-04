using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Altas
    {
        public int Id_Alta { get; set; }
        public int Id_Ingreso_A { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Paciente { get; set; }
        public string Habitacion { get; set; }
        public Double Id_Habitacion { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
