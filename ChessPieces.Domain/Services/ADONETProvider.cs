using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ChessPieces.Domain.Services
{
    public class ADONETProvider
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ChessPieces"].ConnectionString;
        private string tableName;

        public ADONETProvider(string _tableName)
        {
            tableName = _tableName;
        }

        public DataSet Get()
        {
            string sql = $"SELECT * FROM {tableName}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }

        public int Add(string columnName, string columnValues)
        {
            int result = 0;
            string sql = $"INSERT INTO {tableName} ({columnName}) VALUES ({columnValues})";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка!!!\n " + ex.Message);
                }
            }
            return result;
        }

        public int Delete(string columnName, string columnValues)
        {
            int result = 0;
            string sql = $"DELETE FROM {tableName} WHERE {columnName} = {columnValues}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка!!!\n " + ex.Message);
                }
            }
            return result;
        }

        public int Update(string setValues, string vhereValues)
        {
            int result = 0;

            string sql = $"UPDATE {tableName} SET {setValues} WHERE {vhereValues}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка!!!\n " + ex.Message);
                }
            }
            return result;
        }
    }
}
