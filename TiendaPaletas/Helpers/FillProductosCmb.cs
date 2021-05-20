using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TiendaPaletas.Helpers
{
    class FillProductosCmb
    {
        public DataTable productosPorCat(int cat_id)
        {
            dbConection conn = new dbConection();
            string query = @"SELECT * from productos where categoria_id = @cat_id";
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@cat_id", cat_id);
            dt = conn.queryCmd(cmd);
            return dt;
        }

        public DataTable getAllProductos(string nombre)
        {
            dbConection conn = new dbConection();
            string query = @"SELECT * from productos where nombre = @nombre";
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            dt = conn.queryCmd(cmd);
            return dt;
        }
    }
}
