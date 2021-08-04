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
using System.Runtime.Remoting.Messaging;

namespace Negocio.Modelos
{
    public class ModeloHabitaciones
    {
        private int Id_habitacion;
        private string numero;
        private string tipo;
        private double precio;

        private IRepositorioHabitaciones repositorioHabitaciones;
        public EstadoEntidad estado { private get; set; }

        //PROPIEDADES MODELO DE VISTA/ VALIDACION DE DATOS
        public int Id_Habitacion { get => Id_habitacion; set => Id_habitacion = value; }
        [Required(ErrorMessage = "El Campo Numero de habitacion no puede quedar vacio")]
        [RegularExpression("^([0-9]+)-([A-Z]{1})$", ErrorMessage = "Ejemplo numero de habitacion: 500-A")]
        public string Numero { get => numero; set => numero = value; }
        [Required(ErrorMessage ="El Campo Tipo de habitacion no puede quedar vacio")]
        public string Tipo { get => tipo; set => tipo = value; }
        [Required(ErrorMessage = "El Campo Precio de habitacion no debe quedar Vacio")]
        [RegularExpression("^([0-9]+).([0-9]{1})([0-9]{1})*", ErrorMessage = "Debe ingresar un precio decimal: 150.34")]
        public double Precio { get => precio; set => precio = value; }

        public ModeloHabitaciones()
        {
            repositorioHabitaciones = new RepositorioHabitaciones();
        }

        public string GuardarCambios()
        {
            string message = null;
            try
            {
                var modeloDatosHabitaciones = new Habitaciones();
                modeloDatosHabitaciones.Id_Habitacion = Id_habitacion;
                modeloDatosHabitaciones.Numero = numero;
                modeloDatosHabitaciones.Tipo = tipo;
                modeloDatosHabitaciones.Precio = precio;

                switch (estado)
                {
                    case EstadoEntidad.Added:
                        //EJECUTAR REGLAS COMERCIALES/CALCULOS
                        repositorioHabitaciones.Add(modeloDatosHabitaciones);
                        message = "Habitacion Agregada Correctamente";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioHabitaciones.Remove(Id_Habitacion);
                        message = "Habitacion Eliminada Correctamente";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioHabitaciones.Edit(modeloDatosHabitaciones);
                        message = "Habitacion editada correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "El Numero de habitacion que intenta registrar ya existe!!!";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;

        }
        public List<ModeloHabitaciones> GetAll()
        {
            var modeloDatosHabitaciones = repositorioHabitaciones.GetAll();
            var listaHabitaciones = new List<ModeloHabitaciones>();
            foreach (Habitaciones item in modeloDatosHabitaciones)
            {
                listaHabitaciones.Add(new ModeloHabitaciones
                {
                    Id_habitacion = item.Id_Habitacion,
                    numero = item.Numero,
                    tipo= item.Tipo,
                    precio = item.Precio
                });
            }
            return listaHabitaciones;
        }
        
        public IEnumerable<ModeloHabitaciones>BuscarHabitacion(string filter)
        {
            return GetAll().FindAll(e => e.Tipo == filter);
        }
    }
}
