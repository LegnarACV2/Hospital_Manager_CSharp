using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Ingresos
    {
        public int Id_Ingreso { get; set; }
        public string Id_Paciente_I { get; set; }
        public string Id_Habitacion_I { get; set; }
        public DateTime Fecha_Inicio { get; set; }
    }
}
