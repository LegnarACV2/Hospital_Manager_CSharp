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
    public class RepositorioPacientes : RepositorioMaestro, IRepositorioPacientes
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES
        //::::

        //CONSTRUCTORES
        public RepositorioPacientes()
        {
            selectAll = "SELECT * FROM Pacientes";
            insert = "INSERT INTO Pacientes Values (@cedula,@nombre,@asegurado)";
            update = "UPDATE Pacientes SET Cedula=@cedula,Nombre=@nombre,Asegurado=@asegurado WHERE Id_Paciente = @id_paciente";
            delete = "DELETE FROM Pacientes WHERE Id_Paciente = @id_paciente";
        }

        //METODOS O COMPORTAMIENTOS
        public int Add(Pacientes entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@cedula", entity.Cedula));
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@asegurado", entity.Asegurado));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Pacientes entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_paciente", entity.id_Paciente));
            parameters.Add(new SqlParameter("@cedula", entity.Cedula));
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@asegurado", entity.Asegurado));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Pacientes> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listaPacientes = new List<Pacientes>();
            foreach (DataRow item in tableresult.Rows)
            {
                listaPacientes.Add(new Pacientes
                {
                    id_Paciente = Convert.ToInt32(item[0]),
                    Cedula = item[1].ToString(),
                    Nombre = item[2].ToString(),
                    Asegurado = item[3].ToString(),
                });
            }
            return listaPacientes;
        }

        public int Remove(int id_Paciente)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_paciente", id_Paciente));
            return ExecuteNonQuery(delete);
        }
    }
}
