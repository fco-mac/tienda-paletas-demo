using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TiendaPaletas.Helpers
{
    class getCategoryId
    {
        public int getId(string nombre)
        {
            Helpers.dbConection function = new Helpers.dbConection();
            int id;
            string query = @"select id from categorias where nombre = @catNombre";
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@catNombre", nombre);
            dt = function.queryCmd(cmd);
            id = Int32.Parse(dt.Rows[0]["id"].ToString());
            return (int)id;
        }
    }
}
