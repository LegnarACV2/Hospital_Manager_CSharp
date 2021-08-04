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
    public class ModeloIngresos
    {
        private int id_ingreso;
        private string id_paciente_i;
        private string id_habitacion_i;
        private DateTime fecha_inicio;

        private IRepositorioIngresos repositorioIngresos;
        public EstadoEntidad estado { private get; set; }

        //PROPIEDADES MODELO DE VISTA/VALIDACION DE DATOS
        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        [Required(ErrorMessage ="Seleccione un paciente para ingresar")]
        public string Id_paciente_i { get => id_paciente_i; set => id_paciente_i = value; }
        [Required(ErrorMessage ="Debe seleccionar una habitacion para el ingreso")]
        public string Id_habitacion_i { get => id_habitacion_i; set => id_habitacion_i = value; }
        [Required(ErrorMessage = "Debe seleccionar la fecha de ingreso")]
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }

        public ModeloIngresos()
        {
            repositorioIngresos = new RepositorioIngresos();
        }

        public string GuardarCambios()
        {
            string message = null;
            try
            {
                var modeloDatosIngresos = new Ingresos();
                modeloDatosIngresos.Id_Ingreso = id_ingreso;
                modeloDatosIngresos.Id_Paciente_I = id_paciente_i;
                modeloDatosIngresos.Id_Habitacion_I = id_habitacion_i;
                modeloDatosIngresos.Fecha_Inicio = fecha_inicio;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        //EJECUTAR REGLAS COMERCIALES/CALCULOS
                        repositorioIngresos.Add(modeloDatosIngresos);
                        message = "Paciente ingresado Correctamente";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioIngresos.Remove(id_ingreso);
                        message = "Ingreso de paciente eliminado correctamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioIngresos.Edit(modeloDatosIngresos);
                        message = "Ingreso de paciente editado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            return message;
        }

        public List<ModeloIngresos> GetAll()
        {
            var modeloDatosIngresos = repositorioIngresos.GetAll();
            var listaIngresos = new List<ModeloIngresos>();
            foreach (Ingresos item in modeloDatosIngresos)
            {
                listaIngresos.Add(new ModeloIngresos
                {
                    id_ingreso = item.Id_Ingreso,
                    id_paciente_i = item.Id_Paciente_I,
                    id_habitacion_i = item.Id_Habitacion_I,
                    fecha_inicio = item.Fecha_Inicio,
                });
            }
            return listaIngresos;
        }
        public IEnumerable<ModeloIngresos> BuscarIngreso(string filter)
        {
            return GetAll().FindAll(e =>  e.Id_habitacion_i.Contains(filter));
        }

        public IEnumerable<ModeloIngresos> IngresosFecha(DateTime filter)
        {
            return GetAll().FindAll(e => e.Fecha_inicio == filter);
        }
    }
}
