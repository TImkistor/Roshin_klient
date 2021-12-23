using MySql.Data.MySqlClient;


namespace Roshin
{
    public static class DatabaseManager
    {
        private static MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");


        public static void openConnection()
        {
            if (DatabaseManager.connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public static MySqlConnection getConnection()
        {
            return connection;
        }

        public static void Chech()
        {

        }
    }
}
