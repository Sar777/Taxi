using MySql.Data.MySqlClient;
using System;

namespace TaxiSystem.Src.Database.MySQL
{
    class MySQL
    {
        private string Host = "127.0.0.1";
        private string DB = "taxi";
        private string Username = "root";
        private string Password = "";
        private int Port = 3306;

        private MySQL() { }

        public string DatabaseName
        {
            get { return DB; }
            set { DB = value; }
        }

        private MySqlConnection connection = null;
 
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static MySQL _instance = null;
        public static MySQL Instance()
        {
            if (_instance == null)
                _instance = new MySQL();

            return _instance;
        }

        public void PExecute(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader Execute(string query)
        {
            if (!IsConnect())
                return null;

            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public bool IsConnect()
        {
            if (Connection != null)
                return true;

            if (String.IsNullOrEmpty(DatabaseName))
                return false;

            bool result = false;
            try
            {
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}; port={4}", Host, DB, Username, Password, Port);
                connection = new MySqlConnection(connstring);
                connection.Open();
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("MySQL Exeption: {0}", e.Message);
            }

            return result;
        }

        public void BeginTransaction()
        {
            PExecute("START TRANSACTION");
        }

        public void CommitTransaction()
        {
            PExecute("COMMIT");
        }

        public void Close()
        {
            if (connection == null)
                return;

            connection.Close();
            connection = null;
        }

        public override string ToString()
        {
            if (!IsConnect())
                return string.Format("MySQL: Failed connect to {0}", DatabaseName);

            return string.Format("MySQL: Connect to {0}. Server version: {1}", DatabaseName, connection.ServerVersion);
         }
    }
}