using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Models
{
    

    class User
    {
        private string nombre;
        

        Helpers.dbConection function = new Helpers.dbConection();
        public DataTable getUserById(int num, string nombre)
        {
            string busqueda = @"Select * from Usuarios where numero_empleado = @num and nombre  = @nombre";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = busqueda;
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            DataTable result = new DataTable();
            result = function.queryCmd(cmd);
            return result;
        }
    }
}
