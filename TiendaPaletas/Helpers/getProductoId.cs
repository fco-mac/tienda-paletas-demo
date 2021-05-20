using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TiendaPaletas.Helpers
{
    class getProductoId
    {
        public int getId(string nombre)
        {
                dbConection function = new dbConection();
                int id;
                string query = @"select * from productos where nombre = @proNombre";
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@proNombre", nombre);
                dt = function.queryCmd(cmd);
                id = Int32.Parse(dt.Rows[0]["id"].ToString());
                return (int)id;
        }
    }
}
