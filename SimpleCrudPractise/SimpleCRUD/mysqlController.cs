using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SimpleCRUD
{
    public class mysqlController
    {
        MySqlConnectionStringBuilder sb;
        MySqlCommand cmd;
        MySqlConnection conn;



        public void ConnOpen()
        {

            sb = new MySqlConnectionStringBuilder();

            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "battlefury";
            sb.Database = "simple_crud";
            conn = new MySqlConnection(sb.ToString());
            conn.Open();

        }
        public void ConnClose()
        {
            conn.Close();
            
        }

        public DataTable Datatable(string upit)
        {
            try
            {
                ConnOpen();
                cmd = new MySqlCommand(upit, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally { ConnClose(); }
        }

        public void MysqlNonQuery(string upit)
        {

            try
            {
                ConnOpen();
                cmd = new MySqlCommand(upit, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally { ConnClose(); }

        }

        public void InsertUpdateDelete(string upit, params MySqlParameter[] parameters)
        {

            try
            {
                ConnOpen();
                cmd = new MySqlCommand(upit, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw new Exception();
                
            }
            finally { ConnClose(); }

        }







    }
}
