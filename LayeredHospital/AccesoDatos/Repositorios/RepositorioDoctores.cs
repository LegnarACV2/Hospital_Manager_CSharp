using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Contratos;
using AccesoDatos.Entidades;


namespace AccesoDatos.Repositorios
{
    public class RepositorioDoctores : RepositorioMaestro, IRepositorioDoctores
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES 
        //::::

        //CONSTRUCTORES
        public RepositorioDoctores()
        {
            selectAll = "SELECT * FROM Doctores";
            insert = "INSERT INTO Doctores VALUES (@nombre,@exequatur,@especialidad)";
            update = "UPDATE Doctores Set Nombre=@nombre,Exequatur=@exequatur,Especialidad=@especialidad WHERE Id_Doctor = @id_Doctor";
            delete = "DELETE FROM Doctores WHERE Id_Doctor = @id_Doctor";

        }

        //METODOS O COMPORTAMIENTOS
        public int Add(Doctores entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@exequatur", entity.Exequatur));
            parameters.Add(new SqlParameter("@especialidad", entity.Especialidad));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Doctores entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_Doctor", entity.id_Doctor));
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@exequatur", entity.Exequatur));
            parameters.Add(new SqlParameter("@especialidad", entity.Especialidad));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Doctores> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listDoctores = new List<Doctores>();
            foreach (DataRow item in tableresult.Rows)
            {
                listDoctores.Add(new Doctores
                {
                    id_Doctor =  Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Exequatur = item[2].ToString(),
                    Especialidad = item[3].ToString()
                });
            }
            return listDoctores;
        }

        public int Remove(int Id_Doctor)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_Doctor", Id_Doctor));
            return ExecuteNonQuery(delete);
        }
    }
}
