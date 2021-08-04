using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos.Contratos;
using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public class RepositorioHabitaciones : RepositorioMaestro, IRepositorioHabitaciones
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES
        //::::

        //CONSTRUCTORES
        public RepositorioHabitaciones()
        {
            selectAll = "SELECT * FROM Habitaciones";
            insert = "INSERT INTO Habitaciones Values (@numero,@tipo,@precio)";
            update = "UPDATE Habitaciones SET Numero=@numero, Tipo=@tipo, Precio=@precio WHERE Id_Habitacion = @id_habitacion";
            delete = "DELETE FROM Habitaciones WHERE Id_Habitacion = @id_habitacion";
        }

        //METODOS O COMPORTAMIENTOS
        public int Add(Habitaciones entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@numero", entity.Numero));
            parameters.Add(new SqlParameter("@tipo", entity.Tipo));
            parameters.Add(new SqlParameter("@precio", entity.Precio));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Habitaciones entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_habitacion", entity.Id_Habitacion));
            parameters.Add(new SqlParameter("@numero", entity.Numero));
            parameters.Add(new SqlParameter("@tipo", entity.Tipo));
            parameters.Add(new SqlParameter("@precio", entity.Precio));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Habitaciones> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listahabitaciones = new List<Habitaciones>();
            foreach (DataRow item in tableresult.Rows)
            {
                listahabitaciones.Add(new Habitaciones
                {
                    Id_Habitacion = Convert.ToInt32(item[0]),
                    Numero = item[1].ToString(),
                    Tipo = item[2].ToString(),
                    Precio = Convert.ToDouble(item[3]),
                });
            }
            return listahabitaciones;
        }

        public int Remove(int Id_Habitacion)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_habitacion", Id_Habitacion));
            return ExecuteNonQuery(delete);
        }
    }
}
