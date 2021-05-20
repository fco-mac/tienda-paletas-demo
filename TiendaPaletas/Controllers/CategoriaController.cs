using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Controllers
{
    class CategoriaController
    {
        Models.Categoria categoria = new Models.Categoria();
        public DataTable getAllCategories()
        {
            DataTable dt = new DataTable();
            dt = categoria.getAllCategories();
            return dt;
        }

        public string create(string NombreCategoria)
        {
            string message = categoria.create(NombreCategoria);
            return message;
        }

        public string edit(string nuevoN, string viejoN)
        {
            //Recolectamos el nuevo nombre
            string nuevoNombre = nuevoN;

            //Recolectamos Id de la categoria
            int id;
            Helpers.getCategoryId getId = new Helpers.getCategoryId();
            id = getId.getId(viejoN);
            string message = categoria.editCat(id, nuevoNombre);
            return message;
            
        }
    }
}
