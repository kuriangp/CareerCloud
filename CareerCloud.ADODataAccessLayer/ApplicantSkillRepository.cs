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
    public class ApplicantSkillRepository : BaseADO, IDataRepository<ApplicantSkillPoco>
    {
        
        public void Add(params ApplicantSkillPoco[] items)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;

            foreach (ApplicantSkillPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO Applicant_Skills 
                    (Id, Applicant, Skill, Skill_Level, Start_Month, Start_Year, End_Month, End_Year)
                    VALUES
                    (@Id, @Applicant, @Skill, @Skill_Level, @Start_Month, @Start_Year, @End_Month, @End_Year)";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Skill", poco.Skill);
                cmd.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel );
                cmd.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                cmd.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                cmd.Parameters.AddWithValue("@End_Month", poco.EndMonth );
                cmd.Parameters.AddWithValue("@End_Year", poco.EndYear);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillPoco> GetAll(params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * FROM Applicant_Skills";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    ApplicantSkillPoco poco = new ApplicantSkillPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Skill = reader.GetString(2);
                    poco.SkillLevel = reader.GetString(3);
                    poco.StartMonth  = reader.GetByte(4);
                    poco.StartYear = reader.GetInt32 (5);
                    poco.EndMonth  = reader.GetByte(6);
                    poco.EndYear = reader.GetInt32(7);
                    poco.TimeStamp = (byte[])reader[8];
                    pocos[position] = poco;
                    position++;
                }
                _connection.Close();
            }
            return pocos;
        }

        public IList<ApplicantSkillPoco> GetList(System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingle(System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantSkillPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Applicant_Skills 
                        WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params ApplicantSkillPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Applicant_Skills, 
                        SET Applicant = @Applicant,
                            Skill = @Skill,
                            Skill_Level =@Skill_Level,
                            Start_Month =@Start_Month,
                            Start_Year =@Start_Year,
                            End_Month =@End_Month,
                            End_Year =@End_Year,
                        WHERE ID = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", poco.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    cmd.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", poco.StartMonth);
                    cmd.Parameters.AddWithValue("@End_Year", poco.StartYear);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
