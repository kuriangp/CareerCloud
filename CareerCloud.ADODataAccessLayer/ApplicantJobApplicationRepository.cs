using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantJobApplicationRepository : BaseADO, IDataRepository<ApplicantJobApplicationPoco>
    {
        public void Add(params ApplicantJobApplicationPoco[] items)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;

            foreach (ApplicantJobApplicationPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO Applicant_Job_Applications
                    (Id, Applicant, Job, Application_Date)
                    VALUES
                    (@Id, @Applicant,@Job,@Application_Date)";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Job", poco.Job);
                cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationPoco> GetAll(params System.Linq.Expressions.Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * FROM Applicant_Job_Applications";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Job = reader.GetGuid(2);
                    poco.ApplicationDate = reader.GetDateTime(3);
                    poco.TimeStamp = (byte[])reader[4];
                    pocos[position] = poco;
                    position++;
                }

                _connection.Close();
               
            }
            return pocos;
        }
        public IList<ApplicantJobApplicationPoco> GetList(System.Linq.Expressions.Expression<Func<ApplicantJobApplicationPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(System.Linq.Expressions.Expression<Func<ApplicantJobApplicationPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
                IQueryable<ApplicantJobApplicationPoco> pocos = GetAll().AsQueryable();
                return pocos.Where(where).FirstOrDefault();
            }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
                using (_connection)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _connection;
                    foreach (ApplicantJobApplicationPoco poco in items)
                    {
                        cmd.CommandText = @"DELETE FROM Applicant_Job_Applications 
                        WHERE ID = @Id";
                        cmd.Parameters.AddWithValue("@Id", poco.Id);

                        _connection.Open();
                        cmd.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
            }

        public void Update(params ApplicantJobApplicationPoco[] items)
        {
                using (_connection)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _connection;
                    foreach (ApplicantJobApplicationPoco poco in items)
                    {
                        cmd.CommandText = @"UPDATE Applicant_Job_Applications, 
                        SET Applicant = @Applicant,
                        Job = @Job,
                        Application_Date=@Application_Date,
                        WHERE ID = @[Id]";
                        cmd.Parameters.AddWithValue("@Id", poco.Id);
                        cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                        cmd.Parameters.AddWithValue("@Job", poco.Job);
                        cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                        cmd.Parameters.AddWithValue("@Id", poco.Id);

                        _connection.Open();
                        cmd.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
    }
}

        public IList<ApplicantJobApplicationPoco> GetList(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantJobApplicationPoco[] items)
        {
            throw new NotImplementedException();
        }
    }
