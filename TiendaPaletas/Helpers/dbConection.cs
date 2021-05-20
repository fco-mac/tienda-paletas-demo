using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TiendaPaletas.Helpers
{
    public class dbConection
    {
        public static string conString = "Data Source =LAPTOP-890BOM00\\MSSQLSERVER01; Initial Catalog = tiendaPaletas; Integrated Security = True";

        


        public static SqlConnection conectar = new SqlConnection(conString);
        public DataTable queryCmd(SqlCommand cmd)
        {
            //string conString = "Data Source=DESKTOP-HQSUO3T\\SQLEXPRESS;Initial Catalog=tiendaPaletas;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                cmd.Connection = conn;
                var da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static DataSet con(string conx)
        {
            SqlConnection conex = new SqlConnection("Data Source=LAPTOP-890BOM00\\MSSQLSERVER01;Initial Catalog=tiendaPaletas;Integrated Security=True");
            conex.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter sd = new SqlDataAdapter(conx, conex);
            sd.Fill(ds);
            conex.Close();
            return ds;
        }
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if(conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
