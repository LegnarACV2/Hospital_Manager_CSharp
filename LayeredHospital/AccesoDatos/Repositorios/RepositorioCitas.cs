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
    public class RepositorioCitas : RepositorioMaestro, IRepositorioCitas
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES
        //::::

        //CONSTRUCTORES
        public RepositorioCitas()
        {
            selectAll = "SELECT Citas.Id_Cita, Citas.Fecha, Pacientes.Nombre As Paciente, Doctores.Nombre As Doctor, Citas.Hora " +
                "               FROM Citas INNER JOIN Pacientes ON Citas.Id_Paciente_C = Pacientes.Id_Paciente " +
                "                          INNER JOIN Doctores ON Citas.Id_Doctor_C = Doctores.Id_Doctor";
            insert = "INSERT INTO Citas Values (@fecha,@id_paciente_c,@id_doctor_c,@hora)";
            update = "UPDATE Citas SET Fecha=@fecha,Id_Paciente_C=@id_paciente_c,Id_Doctor_C=@id_doctor_c,Hora=@hora WHERE Id_Cita = @id_cita";
            delete = "DELETE FROM Citas WHERE Id_Cita = @id_cita";
        }

        //METODOS O COMPORTAMIENTOS
        public int Add(Citas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@id_paciente_c",  entity.Id_Paciente_C));
            parameters.Add(new SqlParameter("@id_doctor_c", entity.Id_Doctor_C));
            parameters.Add(new SqlParameter("@hora", entity.Hora));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Citas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_cita", entity.Id_Cita));
            parameters.Add(new SqlParameter("@fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@id_paciente_c", entity.Id_Paciente_C));
            parameters.Add(new SqlParameter("@id_doctor_c", entity.Id_Doctor_C));
            parameters.Add(new SqlParameter("@hora", entity.Hora));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Citas> GetAll()
        {
            var tableresult = ExecuteReader(selectAll);
            var listacitas = new List<Citas>();
            foreach (DataRow item in tableresult.Rows)
            {
                listacitas.Add(new Citas
                {
                    Id_Cita = Convert.ToInt32(item[0]),
                    Fecha= Convert.ToDateTime(item[1]),
                    Id_Paciente_C =item[2].ToString(),
                    Id_Doctor_C =  item[3].ToString(),
                    Hora = item[4].ToString(),
                    
                });
            }
            return listacitas;
        }

        public int Remove(int Id_Cita)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_cita", Id_Cita));
            return ExecuteNonQuery(delete);
        }
    }
}
