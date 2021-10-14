using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAPI2
{
    class DBConnection
    {
        private string connLocal = "server=127.0.0.1; user=root; database=verpres3; SSL mode=none";
        private MySqlConnection mySqlConn;

        public DBConnection()
        {
            mySqlConn = new MySqlConnection(connLocal);
        }

        public MySqlDataReader queryProduct(string query)
        {
            MySqlDataReader reader = null;
            try
            {
                mySqlConn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConn);
                reader = mySqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            } catch(Exception ex)
            {
                mySqlConn.Close();
                MessageBox.Show(ex.ToString());
            }
            return reader;
        }

    }
}
