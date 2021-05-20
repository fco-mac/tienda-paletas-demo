using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Models
{
    
    class Producto
    {
        private string nombre;
        private float precio;
        private int stock;
        private int categoria_id;

        Helpers.dbConection function = new Helpers.dbConection();  //Funcion para solicitar querys en base de datos

        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public float getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }

        public int getCategoria_id()
        {
            return this.categoria_id;
        }

        public void setCategoria_id(int categoria_id)
        {
            this.categoria_id = categoria_id;
        }

        public int getStock()
        {
            return this.stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
        
        public string create()
        {
            string message;
            string query = @"INSERT INTO productos values(@nombre, @categoria_id, @precio, @stock)";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nombre", this.getNombre());
            cmd.Parameters.AddWithValue("@categoria_id", this.getCategoria_id());
            cmd.Parameters.AddWithValue("@precio", this.getPrecio());
            cmd.Parameters.AddWithValue("@stock", this.getStock());
            try
            {
                function.queryCmd(cmd);
                message = "SUCCESS";
            }
            catch
            {
                message = "ERROR";
            }
            return message;

        }

        public string editPrducto(int id)
        {
            string query = @"UPDATE productos set nombre = @nombre, precio = @precio, stock = @stock where id = @id";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", this.getNombre());
            cmd.Parameters.AddWithValue("@precio", this.getPrecio());
            cmd.Parameters.AddWithValue("@stock", this.getStock());
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
