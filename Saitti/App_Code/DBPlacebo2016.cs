//Demo DBLogiikkaa oppilastietojen hakemiseen
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace JAMK.ICT.Data
{
    public static class DBPlacebo
    {
        public static DataTable Get3TestStudents()
        {
            //create
            DataTable dt = new DataTable();
            //columns
            dt.Columns.Add("asioid",typeof(string));
            dt.Columns.Add("LastName",typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            //rows
            dt.Rows.Add("A3581", "Waltari","Mika");
	            dt.Rows.Add("B3553", "King", "Stephen");
	            dt.Rows.Add("D9876", "Oksanen", "Sofi");
            return dt;
        }

        public static DataTable GetAllStudentsFromSQLServer(string connectionStr, string taulu, out string viesti)
        {
            // basic principle: connect - execute query - disconnect
            try
            {
                SqlConnection myConn = new SqlConnection(connectionStr);
                myConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + taulu, myConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, taulu);
                viesti = "Tiedot haettu onnistuneesti tietokannasta " + myConn.DataSource;
                return ds.Tables[taulu];
            }
            catch (Exception ex)
            {
                viesti = ex.Message;
                throw;
            }
        }

        public static DataTable GetCitiesFromMysql(string connectionString)
        {
            try
            {
                // try to connect to labranet mysql server and return city as a datatable
                string sql = "SELECT name, countrycode, population FROM City WHERE population > 99999 ORDER BY population DESC";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
