using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Controllers
{
    class ProductoController
    {
        public string create(string nombre, int categoria_id, float precio, int stock)
        {
            Models.Producto producto = new Models.Producto();
            DataTable dt = new DataTable();
            producto.setNombre(nombre);
            producto.setCategoria_id(categoria_id);
            producto.setPrecio(precio);
            producto.setStock(stock);
            string message = producto.create();
            return message;
             //OBTENEMOS
        }

        public DataTable getProductos(string nombre)
        {
            Helpers.getCategoryId getId = new Helpers.getCategoryId();
            Helpers.FillProductosCmb productos = new Helpers.FillProductosCmb();
            int id = getId.getId(nombre);
            DataTable dt = new DataTable();
            dt = productos.productosPorCat(id);
            return dt;

        }

        public DataTable getProductosTotales(string nombre)
        {
            Helpers.FillProductosCmb productos = new Helpers.FillProductosCmb();
            DataTable dt = new DataTable();
            dt = productos.getAllProductos(nombre);
            return dt;

        }

        public string edit(int id,string nombre,float precio, int stock)
        {
            Models.Producto producto = new Models.Producto();
            producto.setNombre(nombre);
            producto.setPrecio(precio);
            producto.setStock(stock);
            string message = producto.editPrducto(id);
            return message;

        }



    }
}
