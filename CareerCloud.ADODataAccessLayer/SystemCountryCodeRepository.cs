using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemCountryCodeRepository : BaseADO, IDataRepository<SystemCountryCodePoco>
    {
        public void Add(params SystemCountryCodePoco[] items)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _connection;

            foreach (SystemCountryCodePoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO System_Country_Codes 
                    (Code, Name)
                    VALUES
                    (@Code, @Name)";
                cmd.Parameters.AddWithValue("@Code", poco.Code);
                cmd.Parameters.AddWithValue("@Name", poco.Name);

                _connection.Open()
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SystemCountryCodePoco> GetAll(params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            SystemCountryCodePoco[] pocos = new SystemCountryCodePoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * FROM System_Country_Codes";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    SystemCountryCodePoco poco = new SystemCountryCodePoco();
                    poco.Code = reader.GetGuid(0);
                    poco.Name = reader.GetString(1);
                    pocos[position] = poco;
                    position++;
                }
                _connection.Close();
            }
            return pocos;
        }

        public IList<SystemCountryCodePoco> GetList(System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, bool>> where, params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodePoco GetSingle(System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, bool>> where, params System.Linq.Expressions.Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            IQueryable<SystemCountryCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SystemCountryCodePoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (SystemCountryCodePoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM System_Country_Codes 
                        WHERE Code = @Code";
                    cmd.Parameters.AddWithValue("@Code", poco.Code);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params SystemCountryCodePoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (SystemCountryCodePoco poco in items)
                {
                    cmd.CommandText = @"UPDATE System_Country_Codes, 
                        SET Name = @Name,
                        WHERE Code = @Code";
                    cmd.Parameters.AddWithValue("@Code", poco.Code);
                    cmd.Parameters.AddWithValue("@Name", poco.Name);
                    cmd.Parameters.AddWithValue("@Code", poco.Code);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
