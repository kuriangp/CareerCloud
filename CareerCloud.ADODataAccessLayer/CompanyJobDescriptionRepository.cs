using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobDescriptionRepository : BaseADO, IDataRepository<CompanyJobDescriptionPoco>
    {
 
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;

            foreach (CompanyJobDescriptionPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO Company_Jobs_Descriptions 
                    (Id,Job, Job_Name, Job_Descriptions)
                    VALUES
                    (@Id, @Job, @Job_Name, @Job_Descriptions)";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Job", poco.Job);
                cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobDescriptionPoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * FROM Company_Jobs_Descriptions";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.JobName = reader.GetString(2);
                    poco.JobDescriptions = reader.GetString(3);
                    poco.TimeStamp = (byte[])reader[4];
                    pocos[position] = poco;
                    position++;
                }
                _connection.Close();
            }
            return pocos;
        }

        public IList<CompanyJobDescriptionPoco> GetList(System.Linq.Expressions.Expression<Func<CompanyJobDescriptionPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(System.Linq.Expressions.Expression<Func<CompanyJobDescriptionPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Company_Jobs_Descriptions 
                        WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Company_Jobs_Descriptions, 
                        SET Job = @Job,
                            Job_Name = @Job_Name,
                            Job_Descriptions =@Job_Descriptions,
                        WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
