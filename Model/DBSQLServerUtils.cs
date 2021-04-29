using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGeckoData.Model
{
    /*Класс хранит в себе метод возвращающий строку для подключения к серверу, по реквизитам заданным в CredentialsForServer*/
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = CredentialsForServer.DataSource;
            builder.UserID = CredentialsForServer.Login;
            builder.Password = CredentialsForServer.Password;
            builder.IntegratedSecurity = false;
            builder.InitialCatalog = CredentialsForServer.DataBase;

            SqlConnection conn = new SqlConnection(builder.ConnectionString);

            return conn;
        }
    }
}
