using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace library.Connection
{
    class Conn
    {
        public MySqlConnection Connection { set; get; }
        private string server;
        private string database;
        private string user;
        private string password;

        public Conn()
        {
            SetConn();
        }

        private void SetConn()
        {
            //defines the configuration parameters for the connection
            server = "localhost";
            database = "newlibrary";
            user = "root";
            password = "rachel";

            //set the connection
            Connection = new MySqlConnection("Server=" + server + ";" + "Database=" + database + ";"
                + "UID=" + user + ";" + "Password=" + password + ";");
        }


        public bool OpenConn()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool CloseConn()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
