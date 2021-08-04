using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.Repositorios
{
    public class RepositorioAltas : RepositorioMaestro, IRepositorioAltas
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string deleted;

        //PROPIEDADES
        //::::

        //CONSTRUCTORES
        public RepositorioAltas()
        {
            selectAll = "SELECT  Altas.Id_Alta, Id_Ingreso_A, Fecha_Ingreso, Paciente, habitacion, Habitaciones.Precio as Precio, Fecha_Salida" +
                "               FROM Altas INNER JOIN Habitaciones ON Altas.id_habitacion = Habitaciones.Id_Habitacion";
            insert = "INSERT INTO Altas Values (@id_ingreso_a,@fecha_ingreso,@paciente,@habitacion,@id_habitacion,@fecha_salida)";
            update = "UPDATE Altas SET Id_Ingreso_A=@id_ingreso_a,Fecha_Ingreso=@fecha_ingreso,Paciente=@paciente,habitacion=@habitacion,Id_Habitacion=@id_habitacion,Fecha_Salida=@fecha_salida WHERE Id_Alta = @id_alta";
            deleted = "DELETE FROM Altas WHERE Id_Alta = @id_alta";
        }

        public int Add(Altas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_ingreso_a", entity.Id_Ingreso_A));
            parameters.Add(new SqlParameter("@fecha_ingreso", entity.FechaIngreso));
            parameters.Add(new SqlParameter("@paciente", entity.Paciente));
            parameters.Add(new SqlParameter("@habitacion", entity.Habitacion));
            parameters.Add(new SqlParameter("@id_habitacion", entity.Id_Habitacion));
            parameters.Add(new SqlParameter("@fecha_salida", entity.FechaSalida));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Altas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_alta", entity.Id_Alta));
            parameters.Add(new SqlParameter("@id_ingreso_a", entity.Id_Ingreso_A));
            parameters.Add(new SqlParameter("@fecha_ingreso", entity.FechaIngreso));
            parameters.Add(new SqlParameter("@paciente", entity.Paciente));
            parameters.Add(new SqlParameter("@habitacion", entity.Habitacion));
            parameters.Add(new SqlParameter("@id_habitacion", entity.Id_Habitacion));
            parameters.Add(new SqlParameter("@fecha_salida", entity.FechaSalida));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Altas> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listaAltas = new List<Altas>();
            foreach (DataRow item in tableresult.Rows)
            {
                listaAltas.Add(new Altas
                {
                    Id_Alta = Convert.ToInt32(item[0]),
                    Id_Ingreso_A = Convert.ToInt32(item[1]),
                    FechaIngreso = Convert.ToDateTime(item[2]),
                    Paciente = item[3].ToString(),
                    Habitacion = item[4].ToString(),
                    Id_Habitacion = Convert.ToDouble(item[5]),
                    FechaSalida = Convert.ToDateTime(item[6])
                });
            }
            return listaAltas;
        }

        public int Remove(int id_PrimaryKey)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_alta", id_PrimaryKey));
            return ExecuteNonQuery(deleted);
        }
    }
}
