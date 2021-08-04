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
    public class RepositorioIngresos : RepositorioMaestro, IRepositorioIngresos
    {

        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES
        //::::

        //CONSTRUCTORES
        public RepositorioIngresos()
        {
            selectAll = "SELECT Ingresos.id_Ingreso, Pacientes.Nombre As Paciente, Habitaciones.Numero As Habitacion, Ingresos.Fecha_Inicio AS Fecha " +
                "               FROM Ingresos INNER JOIN Pacientes ON Ingresos.Id_Paciente_I = Pacientes.Id_Paciente " +
                "               INNER JOIN Habitaciones ON Ingresos.Id_Habitacion_I = Habitaciones.Id_Habitacion";

            insert = "INSERT INTO Ingresos Values (@id_paciente_i,@id_habitacion_i,@fecha_inicio)";
            update = "UPDATE Ingresos SET id_Paciente_I=@id_paciente_i,Id_Habitacion_I=@id_habitacion_i,Fecha_Inicio=@fecha_inicio WHERE id_Ingreso = @id_ingreso";
            delete = "DELETE FROM Ingresos WHERE id_Ingreso = @id_ingreso";
        }

        //METODOS O COMPORTAMIENTOS
        public int Add(Ingresos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_paciente_i", entity.Id_Paciente_I));
            parameters.Add(new SqlParameter("@id_habitacion_i", entity.Id_Habitacion_I));
            parameters.Add(new SqlParameter("@fecha_inicio", entity.Fecha_Inicio));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Ingresos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_ingreso", entity.Id_Ingreso));
            parameters.Add(new SqlParameter("@id_paciente_i", entity.Id_Paciente_I));
            parameters.Add(new SqlParameter("@id_habitacion_i", entity.Id_Habitacion_I));
            parameters.Add(new SqlParameter("@fecha_inicio", entity.Fecha_Inicio));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Ingresos> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listaingresos = new List<Ingresos>();
            foreach (DataRow item in tableresult.Rows)
            {
                listaingresos.Add(new Ingresos
                {
                    Id_Ingreso = Convert.ToInt32(item[0]),
                    Id_Paciente_I = item[1].ToString(),
                    Id_Habitacion_I = item[2].ToString(),
                    Fecha_Inicio = Convert.ToDateTime(item[3]),
                });
            }
            return listaingresos;
        }

        public int Remove(int Id_Ingreso)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_ingreso ", Id_Ingreso));
            return ExecuteNonQuery(delete);
        }
    }
}
