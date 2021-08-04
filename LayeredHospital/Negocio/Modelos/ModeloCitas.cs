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
    public class ModeloCitas
    {
        private int id_cita;
        private DateTime fecha;
        private string id_paciente_c;
        private string id_doctor_c;
        private string hora;

        private IRepositorioCitas repositorioCitas;

        public EstadoEntidad estado { private get; set; }

        //PROPIEDADES MODELO DE VISTA/VALIDACION DE DATOS
        public int Id_cita { get => id_cita; set => id_cita = value; }
        [Required(ErrorMessage ="Debe Seleccionarse una Fecha para la cita")]
        public DateTime Fecha { get => fecha; set => fecha = value; }
        [Required(ErrorMessage ="Debe seleccionar un paciente para la cita")]
        public string Id_paciente_c { get => id_paciente_c; set => id_paciente_c = value; }
        [Required(ErrorMessage ="Debe seleccionar un doctor para la cita")]
        public string Id_doctor_c { get => id_doctor_c; set => id_doctor_c = value; }
        [Required(ErrorMessage ="Debe ingresar la hora para la cita")]
        [RegularExpression("^([0-9]+):([0-9]{2})*", ErrorMessage = "Debe ingresar la hora en formato HH:MM = 02:30 o 14:30")]
        public string Hora { get => hora; set => hora = value; }

        public ModeloCitas()
        {
            repositorioCitas = new RepositorioCitas();
        }

        public string GuardarCambios()
        {
            string message = null;
            try
            {
                var modeloDatosCitas = new Citas();
                modeloDatosCitas.Id_Cita = id_cita;
                modeloDatosCitas.Fecha = fecha;
                modeloDatosCitas.Id_Paciente_C = id_paciente_c;
                modeloDatosCitas.Id_Doctor_C = id_doctor_c;
                modeloDatosCitas.Hora = hora;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        //EJECUTAR REGLAS COMERCIALES/CALCULOS
                        repositorioCitas.Add(modeloDatosCitas);
                        message = "Cita registrada Exitosamente";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioCitas.Remove(id_cita);
                        message = "Cita Eliminada Exitosamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioCitas.Edit(modeloDatosCitas);
                        message = "Cita editada Exitosamente";
                        break;
                }
            }
            catch (Exception ex)
            {

                message = ex.ToString();
            }
            return message;
        }

        public List<ModeloCitas> GetAll()
        {
            var modeloDatosCitas = repositorioCitas.GetAll();
            var listaCitas = new List<ModeloCitas>();
            foreach (Citas item in modeloDatosCitas)
            {
                listaCitas.Add(new ModeloCitas
                {
                    id_cita = item.Id_Cita,
                    fecha = item.Fecha,
                    id_paciente_c= item.Id_Paciente_C,
                    id_doctor_c = item.Id_Doctor_C,
                    hora = item.Hora
                });
            }
            return listaCitas;
        }

        public IEnumerable<ModeloCitas> BuscarCitas(string filter)
        {
            return GetAll().FindAll(e => e.Id_paciente_c.Contains(filter) || e.Id_doctor_c.Contains(filter));
        }
        public IEnumerable<ModeloCitas> IngresosFecha(DateTime filter)
        {
            return GetAll().FindAll(e => e.Fecha == filter);
        }
    }
}
