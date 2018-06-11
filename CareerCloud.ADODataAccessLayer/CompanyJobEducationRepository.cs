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
    public class CompanyJobEducationRepository : BaseADO, IDataRepository<CompanyJobEducationPoco>
    {
        public void Add(params CompanyJobEducationPoco[] items)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;

            foreach (CompanyJobEducationPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO Company_Job_Educations 
                    (Id, Job, Major, Importance)
                    VALUES
                    (@Id, @Job, @Major, @Importance)";
                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Job", poco.Job);
                cmd.Parameters.AddWithValue("@Major", poco.Major);
                cmd.Parameters.AddWithValue("@Importance", poco.Importance);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobEducationPoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * FROM Company_Job_Educations";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    CompanyJobEducationPoco poco = new CompanyJobEducationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.Major = reader.GetString(2);
                    poco.Importance = reader.GetInt16(3);
                    poco.TimeStamp = (byte[])reader[4];
                    pocos[position] = poco;
                    position++;
                }
                _connection.Close();
            }
            return pocos;
        }

        public IList<CompanyJobEducationPoco> GetList(System.Linq.Expressions.Expression<Func<CompanyJobEducationPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobEducationPoco GetSingle(System.Linq.Expressions.Expression<Func<CompanyJobEducationPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobEducationPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobEducationPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Company_Job_Educations 
                        WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params CompanyJobEducationPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobEducationPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Company_Job_Educations, 
                        SET Job = @Job,
                            Major = @Major,
                            Importance =@Importance,
                       WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Major", poco.Major);
                    cmd.Parameters.AddWithValue("@Importance", poco.Importance);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
