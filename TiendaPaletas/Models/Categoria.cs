using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Models
{
    class Categoria
    {
        Helpers.dbConection function = new Helpers.dbConection();  //Funcion para solicitar querys en base de datos

        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public DataTable getAllCategories()
        {
            string query = "Select * from categorias";
            cmd.CommandText = query;
            dt = function.queryCmd(cmd);
            return dt;
        }

        public string create(string categoriaNueva)
        {
            string message = "Success";
            try { 
            string query = "Insert into categorias values (@categoriaNueva)";
            cmd.Parameters.AddWithValue("@categoriaNueva", categoriaNueva);
            cmd.CommandText = query;
            function.queryCmd(cmd);
            }
            catch
            {
                message = "Fail";
            }
            return message;
        }

        public string editCat(int id, string nombre)
        {
            //Recolectamos id y nombre a cambiar;
            string query = @"UPDATE categorias set nombre = @nuevoNombre where id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nuevoNombre", nombre);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = query;
            try
            {
                function.queryCmd(cmd);
                return "SUCCESS";
            }
            catch
            {
                return "ERROR";
            }
        }
    }
}
