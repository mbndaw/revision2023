using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace revision1App1.DAO
{
    internal class DatabaseHelper
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        private void Connection()
        {
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    _connection = new SqlConnection();
                    _connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\LENOVO X1\\Documents\\revision.mdf\";Integrated Security=True;Connect Timeout=30";
                    _connection.Open();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public void ExecuteUpdate(string sql)
        {
            try
            {
                Connection();
                _command = new SqlCommand(sql, _connection);
                //_command= new SqlCommand();
                // _command.Connection= _connection;
                //_command.CommandText= sql;
                _command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                Connection();
                _command = new SqlCommand(sql, _connection);
                //_command= new SqlCommand();
                // _command.Connection= _connection;
                //_command.CommandText= sql;
                return _command.ExecuteReader();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
