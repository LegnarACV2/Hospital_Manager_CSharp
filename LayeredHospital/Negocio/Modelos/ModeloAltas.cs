using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using AccesoDatos.Contratos;
using Negocio.ObjetosValores;
using System.ComponentModel.DataAnnotations;


namespace Negocio.Modelos
{
    public class ModeloAltas
    {
        private int id_alta;
        private int id_ingreso_a;
        private DateTime fecha_ingreso;
        private string paciente;
        private string habitacion;
        private double id_habitacion;
        private DateTime fecha_salidad;
        private int dias;
        private double monto;

        private IRepositorioAltas repositorioAltas;
        public EstadoEntidad estado { private get; set; }
        
        //PROPIEDADES MODELO DE VISTA / VALIDACION DE ATOS

        public int Id_alta { get => id_alta; set => id_alta = value; }
        public int Id_ingreso_a { get => id_ingreso_a; set => id_ingreso_a = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Paciente { get => paciente; set => paciente = value; }
        public string Habitacion { get => habitacion; set => habitacion = value; }
        public double Id_habitacion { get => id_habitacion; set => id_habitacion = value; }
        public DateTime Fecha_salidad { get => fecha_salidad; set => fecha_salidad = value; }
        public int Dias { get => dias; set => dias = value; }
        public double Monto { get => monto; set => monto = value; }

        public ModeloAltas()
        {
            repositorioAltas = new RepositorioAltas();
        }

        public string GuardarCambios() 
        {
            string messsage = null;
            try
            {
                var modeloDatosAltas = new Altas();
                modeloDatosAltas.Id_Alta = id_alta;
                modeloDatosAltas.Id_Ingreso_A = id_ingreso_a;
                modeloDatosAltas.FechaIngreso = fecha_ingreso;
                modeloDatosAltas.Paciente = paciente;
                modeloDatosAltas.Habitacion = habitacion;
                modeloDatosAltas.Id_Habitacion = id_habitacion;
                modeloDatosAltas.FechaSalida = fecha_salidad;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        repositorioAltas.Add(modeloDatosAltas);
                        messsage = "Paciente dado de Alta, con Eexito";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioAltas.Remove(id_alta);
                        messsage = "Alta medica eliminada correctamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioAltas.Edit(modeloDatosAltas);
                        messsage = "Alta medica eliminada correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            return messsage;
        }

        public List<ModeloAltas> GetAll()
        {
            var modeloDatosAltas = repositorioAltas.GetAll();
            var listaaltas = new List<ModeloAltas>();
            foreach (Altas item in modeloDatosAltas)
            {
                TimeSpan time =  item.FechaSalida - item.FechaIngreso;
                listaaltas.Add(new ModeloAltas
                {
                    id_alta = item.Id_Alta,
                    id_ingreso_a = item.Id_Ingreso_A,
                    fecha_ingreso = item.FechaIngreso,
                    paciente = item.Paciente,
                    habitacion = item.Habitacion,
                    id_habitacion = item.Id_Habitacion,
                    fecha_salidad = item.FechaSalida,
                    dias = time.Days,
                    monto = item.Id_Habitacion*(Convert.ToDouble(time.Days)),
                });
            }
            return listaaltas;
        }

        public IEnumerable<ModeloAltas> FiltrarAltas(string filter)
        {
            return GetAll().FindAll(e => e.Paciente.Contains(filter));
        }

    }
}