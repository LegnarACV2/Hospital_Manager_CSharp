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
    public class ModeloDoctores
    {
        private int Id_Doctor;
        private string nombre;
        private string exequatur;
        private string especialidad;

        private IRepositorioDoctores repositorioDoctores;
        public EstadoEntidad estado { private get; set; }

        //PROPIEDADES MODELO DE VISTA/VALIDACION DE DATOS
        public int Id_Doctor1 { get => Id_Doctor; set => Id_Doctor = value; }
        [Required(ErrorMessage ="El Campo nombre no puede quedar vacio")]
        [StringLength(maximumLength:100,MinimumLength =3, ErrorMessage ="El minimo de letras para el nombre son 3")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage ="Debe ingresar el exequatur del Doctor")]
        [StringLength(maximumLength:58, MinimumLength =9, ErrorMessage ="El minimo de caracteres para el Exequatur es 9")]
        public string Exequatur { get => exequatur; set => exequatur = value; }
        [Required(ErrorMessage ="El campo especialidad es requerido para el Doctor a ingresar")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage ="El Campo especialidad solo debe contener letras")]
        public string Especialidad { get => especialidad; set => especialidad = value; }


        public ModeloDoctores()
        {
            repositorioDoctores = new RepositorioDoctores();
        }
        public string GuardarCambios()
        {
            string message = null;
            try
            {
                var modeloDatosDoctores = new Doctores();
                modeloDatosDoctores.id_Doctor = Id_Doctor;
                modeloDatosDoctores.Nombre = nombre;
                modeloDatosDoctores.Exequatur = exequatur;
                modeloDatosDoctores.Especialidad = especialidad;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        //EJECUTAR REGLAS COMERCIALES/CALCULOS
                        repositorioDoctores.Add(modeloDatosDoctores);
                        message = "Doctor Agregado de manera Exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioDoctores.Remove(Id_Doctor);
                        message = "Doctor Eliminado Exitosamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioDoctores.Edit(modeloDatosDoctores);
                        message = "Doctor editado Satisfactoriamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "El Exequatur que intenta registrar ya existe!!!";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }
        public List<ModeloDoctores> GetAll()
        {
            var modeloDatosDoctores = repositorioDoctores.GetAll();
            var listaDoctores = new List<ModeloDoctores>();
            foreach (Doctores item in modeloDatosDoctores)
            {
                listaDoctores.Add(new ModeloDoctores
                {
                    Id_Doctor = item.id_Doctor,
                    nombre = item.Nombre,
                    exequatur = item.Exequatur,
                    especialidad = item.Especialidad
                });
            }
            return listaDoctores;
        }
        public IEnumerable<ModeloDoctores>BuscarDoctores(string filter)
        {
            return GetAll().FindAll(e => e.Especialidad.Contains(filter) || e.Nombre.Contains(filter));
        }
    }
}
