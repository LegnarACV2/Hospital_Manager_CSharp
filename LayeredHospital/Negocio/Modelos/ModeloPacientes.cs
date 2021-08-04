using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using Negocio.ObjetosValores;
using AccesoDatos.Contratos;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Modelos
{
    public class ModeloPacientes
    {
        private int id_Paciente;
        private string cedula;
        private string nombre;
        private string asegurado;

        private IRepositorioPacientes repositorioPacientes;
        public EstadoEntidad estado { private get; set; }

        //PROPIEDADES MODELO DE VISTA/VALIDACION DE DATOS

        public int Id_Paciente { get => id_Paciente; set => id_Paciente = value; }
        [Required(ErrorMessage ="El Campo Cedula de Paciente no puede quedar Vacio")]
        [RegularExpression("^(([0-9-]{3})+)-(([0-9-]{7})+)-([0-9]{1})$", ErrorMessage = "Ingrese Una Cedula Valida")]
        public string Cedula { get => cedula; set => cedula = value; }
        [Required(ErrorMessage ="El campo Nombre de Paciente no puede quedar vacio")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "El Nombre del paciente solo debe tener Letras")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage ="El Campo Asegurado del paciente no debe quedar vacio")]
        public string Asegurado { get => asegurado; set => asegurado = value; }

        public ModeloPacientes()
        {
            repositorioPacientes = new RepositorioPacientes();
        }

        public string GuardarCambios()
        {
            string message = null;
            try
            {
                var modeloDatosPaciente = new Pacientes();
                modeloDatosPaciente.id_Paciente = id_Paciente;
                modeloDatosPaciente.Cedula = cedula;
                modeloDatosPaciente.Nombre = nombre; 
                modeloDatosPaciente.Asegurado = asegurado;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        //EJECUTAR REGLAS COMERCIALES DE CALCULOS
                        repositorioPacientes.Add(modeloDatosPaciente);
                        message = "Paciente Agrefado Satisfactoriamente";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioPacientes.Remove(id_Paciente);
                        message = "Paciente Eliminado Satisfactoriamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioPacientes.Edit(modeloDatosPaciente);
                        message = "Paciente Editado Satisfactoriamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEX = ex as System.Data.SqlClient.SqlException;
                if (sqlEX != null && sqlEX.Number == 2627)
                {
                    message = "La cedula que intenta ingresar ya Existe!!!";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }
        public List<ModeloPacientes> GetAll()
        {
            var modeloDatosPaciente = repositorioPacientes.GetAll();
            var listaPacientes = new List<ModeloPacientes>();
            foreach (Pacientes item in modeloDatosPaciente)
            {
                listaPacientes.Add(new ModeloPacientes
                {
                    id_Paciente = item.id_Paciente,
                    cedula = item.Cedula,
                    nombre = item.Nombre,
                    asegurado = item.Asegurado
                });
            }
            return listaPacientes;
        }
        public IEnumerable<ModeloPacientes>BuscarPaciente(string filter)
        {
            return GetAll().FindAll(e => e.Nombre.Contains(filter) || e.Cedula.Contains(filter) || e.Asegurado==filter);
        }
    }
}
