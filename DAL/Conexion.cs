using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace HorarioApi.DAL
{
    public class Conexion
    {
        protected string ConnectionString { get; set; }

        public Conexion()
        {
            this.ConnectionString = ConfigurationManager.AppSettings["conex"].ToString();
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }
    }
}