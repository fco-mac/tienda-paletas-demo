using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using TiendaPaletas.Controllers;
using System.Collections;
using System.Text.RegularExpressions;

namespace TiendaPaletas.Views
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        public static int id_grupo;
        public static int id_producto;
        private static bool valido = false;
        private static bool valido2 = false;
        string query;
        private void insertarCategoria()
        {
            try
            {
                Helpers.dbConection.abrir();
                SqlCommand con = new SqlCommand("insertarCategoria",Helpers.dbConection.conectar);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@nombre",txtCategoria.Text.Trim());
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                con.Parameters.AddWithValue("@imagen", ms.GetBuffer());
                con.ExecuteNonQuery();
                Helpers.dbConection.cerrar();
            }
            catch(Exception ex)
            {
                Helpers.dbConection.cerrar();
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarCategoria() 
        {
            try
            {
                Helpers.dbConection.abrir();
                SqlCommand con = new SqlCommand("eliminarCategoria", Helpers.dbConection.conectar);
                con.CommandType = CommandType.StoredProcedure;

                con.Parameters.AddWithValue("@id", id_grupo);
                
                DialogResult resEliminado = MessageBox.Show("¿Está seguro que desea eliminar la categoría y sus características de manera permanente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resEliminado == DialogResult.OK)
                {
                    int catEliminada = con.ExecuteNonQuery();

                    dibujarCategoria();
                    
                }
                Helpers.dbConection.cerrar();
            }
            catch (Exception ex)
            {
                Helpers.dbConection.cerrar();
                MessageBox.Show(ex.Message);
            }
        }
        private void insertarProducto()
        {
            try
            {
                Helpers.dbConection.abrir();
                SqlCommand con = new SqlCommand("insertarProducto", Helpers.dbConection.conectar);                
                con.CommandType = CommandType.StoredProcedure;

                con.Parameters.AddWithValue("@nombre",txtProducto.Text.Trim());
                con.Parameters.AddWithValue("@idCategoria", id_grupo);
                con.Parameters.AddWithValue("@precioProd", float.Parse(txtPrecio.Text.Trim()));
                con.Parameters.AddWithValue("@cantidadProd", int.Parse(txtCantidad.Text.Trim()));
                con.Parameters.AddWithValue("@tamañoProd", cbTamañoProducto.SelectedItem.ToString());
                
                MemoryStream ms2 = new MemoryStream();
                pictureBoxProd.Image.Save(ms2, pictureBoxProd.Image.RawFormat);
                con.Parameters.AddWithValue("@imagenProd", ms2.GetBuffer());
                con.ExecuteNonQuery();
                
                Helpers.dbConection.cerrar();
            }
            catch (Exception ex)
            {
                Helpers.dbConection.cerrar();
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarProducto()
        {
            try
            {
                Helpers.dbConection.abrir();
                SqlCommand con = new SqlCommand("eliminarProducto", Helpers.dbConection.conectar);
                con.CommandType = CommandType.StoredProcedure;

                con.Parameters.AddWithValue("@nombre", txtProducto.Text.Trim());//posible bug
                con.Parameters.AddWithValue("@idCategoria", id_grupo);

                
                
                DialogResult resEliminado = MessageBox.Show("¿Está seguro que desea eliminar el producto y sus características de manera permanente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(resEliminado == DialogResult.OK)
                {
                    limpiarCamposProd();
                    dataGridViewProd.Rows.Remove(dataGridViewProd.SelectedRows[0]);
                    int prodEliminado = con.ExecuteNonQuery();
                }
                Helpers.dbConection.cerrar();
            }
            catch (Exception ex)
            {
                Helpers.dbConection.cerrar();
                MessageBox.Show(ex.Message);
            }
        }

        
        private void agregarImagen()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Images|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = new Bitmap(dlg.FileName);
                panel3.Visible = true;               
                pictureBox1.BringToFront();
            }
        }

        private void agregarImagenProd()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Images|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProd.BackgroundImage = null;
                pictureBoxProd.Image = new Bitmap(dlg.FileName);
                
                pictureBoxProd.BringToFront();
            }
        }
        private void dibujarCategoria()
        {
            pnCategoria.Visible = true;
            pnCategoria.Dock = DockStyle.Fill;
            flowPnCategorias.Controls.Clear();
            
            

            try
            {
                Helpers.dbConection.abrir();
                query = string.Format("SELECT * FROM categorias");
                SqlCommand con = new SqlCommand(query,Helpers.dbConection.conectar);
                SqlDataReader dr = con.ExecuteReader();
                while (dr.Read())
                {
                    Label b = new Label();
                    Panel pn1 = new Panel();
                    Panel pn2 = new Panel();
                    PictureBox pic = new PictureBox();

                    b.Text = dr["nombre"].ToString();
                    b.Name = dr["id"].ToString();
                    b.Size = new System.Drawing.Size(119, 25);
                    b.Font = new System.Drawing.Font("Roboto", 14, FontStyle.Bold);                    
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.FromArgb(102, 165, 173);
                    b.Dock = DockStyle.Fill;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;

                    pn1.Size = new System.Drawing.Size(140, 133);                    
                    pn1.BorderStyle = BorderStyle.None;
                    pn1.Dock = DockStyle.Bottom;
                    pn1.BackColor = Color.Transparent;
                    pn1.Name = dr["id"].ToString();

                    pn2.Size = new System.Drawing.Size(140, 25);
                    pn2.Dock = DockStyle.Top;
                    pn2.BackColor = Color.Transparent;
                    pn2.BorderStyle = BorderStyle.None;

                    pic.Size = new System.Drawing.Size(140, 76);
                    pic.Dock = DockStyle.Top;
                    pic.BackgroundImage = null;
                    byte[] bit = (Byte[])dr["imagen"];
                    MemoryStream ms = new MemoryStream(bit);
                    pic.Image = Image.FromStream(ms);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Cursor = Cursors.Hand;
                    pic.Tag = dr["id"].ToString();

                    MenuStrip menustrip = new MenuStrip();
                    menustrip.BackColor = Color.Transparent;
                    menustrip.AutoSize = false;
                    menustrip.Size = new System.Drawing.Size(28, 24);
                    menustrip.Dock = DockStyle.Right;
                    menustrip.Name = dr["id"].ToString();
                    

                    ToolStripMenuItem toolprincipal = new ToolStripMenuItem();
                    ToolStripMenuItem tooleliminar = new ToolStripMenuItem();
                    ToolStripMenuItem tooleditar = new ToolStripMenuItem();
                    //ToolStripMenuItem toolrestaurar = new ToolStripMenuItem();

                    toolprincipal.Image = Properties.Resources.menuCajas_claro;
                    toolprincipal.BackColor = Color.Transparent;

                    tooleditar.Text = "Editar";
                    tooleditar.Name = dr["nombre"].ToString();
                    tooleditar.Tag = dr["id"].ToString();
                    

                    tooleliminar.Text = "Eliminar";
                    tooleliminar.Tag = dr["id"].ToString();
                    /*toolrestaurar.Text = "Restaurar";
                    toolrestaurar.Tag = dr["id"].ToString();*/

                    menustrip.Items.Add(toolprincipal);
                    toolprincipal.DropDownItems.Add(tooleditar);
                    toolprincipal.DropDownItems.Add(tooleliminar);
                    //toolprincipal.DropDownItems.Add(toolrestaurar);

                    pn2.Controls.Add(menustrip);
                    pn1.Controls.Add(b);
                    pn1.Controls.Add(pic);
                    pn1.Controls.Add(pn2);
                    b.BringToFront();
                    pn2.SendToBack();
                    flowPnCategorias.Controls.Add(pn1);
                    flowPnCategorias.Dock = DockStyle.Fill;

                    b.Click += new EventHandler(evento_label);
                    pic.Click += new EventHandler(evento_imagen);
                    tooleditar.Click += new EventHandler(evento_editar_categoria);
                    tooleliminar.Click += new EventHandler(evento_eliminar_categoria);
                    
                    
                }
                Helpers.dbConection.cerrar();
            }
            catch (Exception ex)
            {
                Helpers.dbConection.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
        }


        /*private void dibujarProductoEmpleado()
        {
            pnProductos.Visible = true;
            pnProductos.Dock = DockStyle.Fill;
            //flowPnProductos.Controls.Clear();
            try
            {
                Helpers.dbConection.abrir();
                SqlCommand con = new SqlCommand("mostrarProductos", Helpers.dbConection.conectar);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id_grupo);
                SqlDataReader dr = con.ExecuteReader();
                while (dr.Read())
                {
                    Label b = new Label();
                    Panel pn1 = new Panel();

                    b.Text = dr["nombre"].ToString();
                    b.Name = dr["categoria_id"].ToString();
                    b.Tag = dr["id"].ToString();
                    b.Size = new System.Drawing.Size(195, 25);
                    b.Font = new System.Drawing.Font("Roboto", 14, FontStyle.Bold);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.White;
                    b.Dock = DockStyle.Fill;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;*/

        /*pn1.Size = new System.Drawing.Size(200, 30);
        pn1.BorderStyle = BorderStyle.FixedSingle;
        pn1.BackColor = Color.FromArgb(43, 43, 43);
        pn1.Name = dr["id"].ToString();*/

        /*MenuStrip menustrip = new MenuStrip();
        menustrip.BackColor = Color.Transparent;
        menustrip.AutoSize = false;
        menustrip.Size = new System.Drawing.Size(28, 24);
        menustrip.Dock = DockStyle.Right;
        menustrip.Name = dr["id"].ToString();

        ToolStripMenuItem toolprincipal = new ToolStripMenuItem();
        ToolStripMenuItem tooleliminar = new ToolStripMenuItem();
        ToolStripMenuItem tooleditar = new ToolStripMenuItem();
        ToolStripMenuItem toolrestaurar = new ToolStripMenuItem();

        toolprincipal.Image = Properties.Resources.menuCajas_claro;
        toolprincipal.BackColor = Color.Transparent;

        tooleditar.Text = "Editar";
        tooleditar.Name = dr["nombre"].ToString();
        tooleditar.Tag = dr["id"].ToString();

        tooleliminar.Text = "Eliminar";
        tooleliminar.Tag = dr["id"].ToString();

        toolrestaurar.Text = "Precio Venta";
        toolrestaurar.Tag = dr["id"].ToString();

        menustrip.Items.Add(toolprincipal);
        toolprincipal.DropDownItems.Add(tooleditar);
        toolprincipal.DropDownItems.Add(tooleliminar);
        toolprincipal.DropDownItems.Add(toolrestaurar);

        pn1.Controls.Add(menustrip);
        pn1.Controls.Add(b);

        b.BringToFront();
        //flowPnProductos.Controls.Add(pn1);
        pnProductos.Dock = DockStyle.Fill;
    }
    Helpers.dbConection.cerrar();
}
catch (Exception ex)
{
    Helpers.dbConection.cerrar();
    MessageBox.Show(ex.StackTrace);
}
}*/

        public DataSet llenadt(string llen, int categoria)
        {
            string consDt = string.Format("select * from " +llen+ " inner join Categorias on Categorias.id = Productos.categoria_id where Categorias.id = " + categoria);
            DataSet dsdt = Helpers.dbConection.con(consDt);
            return dsdt;
        }

        private void dibujarProducto()
        {
            
            pnProductos.Visible = true;
            pnProductos.Dock = DockStyle.Fill;
           

            try
            {
                
                Helpers.dbConection.abrir();
                dataGridViewProd.DataSource = llenadt("Productos",id_grupo).Tables[0];
                /*
                SqlCommand con = new SqlCommand("mostrarProductos", Helpers.dbConection.conectar);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id_grupo);
                SqlDataReader dr = con.ExecuteReader();
                CategoriaController cc = new CategoriaController();
                DataTable dtcp = new DataTable();
               
                dtcp = cc.getAllCategories();    
                ProductoController fillProd = new ProductoController();
                string id = "";
                id = dtcp.Rows[id_grupo]["nombre"].ToString();//linea del posible error al eliminar categoría
                dataGridViewProd.DataSource = fillProd.getProductos(id);
                dataGridViewProd.AutoGenerateColumns = false;
                */
                Helpers.dbConection.cerrar();
            }
            catch (Exception ex)
            {
                Helpers.dbConection.cerrar();       
                MessageBox.Show(ex.Message);
            }
            
        }

        
        

        private void evento_label(object sender, EventArgs e)
        {
            id_grupo = Convert.ToInt32(((Label)sender).Name);
            ver_producto_por_grupo();
        }
        private void evento_imagen(object sender, EventArgs e)
        {
            id_grupo = Convert.ToInt32(((PictureBox)sender).Tag);
            ver_producto_por_grupo();
        }

        private void evento_editar_categoria(object sender, EventArgs e)
        {
            /*lo que se trata de hacer aqui es utilizar el mismo stored procedure para actualizar y 
             * guardar, tal como se hizo con el de insertar producto, solo que en este caso el error
             * está en que al querer editar el nombre, la categoria se almacena como una nueva
             * lo que debe hacer es editar el nombre y que se guarde como nombre de la categoria seleccionada
             * no se si sea problema del código o del storedprocedure
             */
            id_grupo = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            String nomCat = ((ToolStripMenuItem)sender).Name;
            btnAgregarGrupo.Text = "Actualizar";
            txtCategoria.Text = nomCat;
            pnAgregarCategoria.Visible = true;
            pnCategoria.Visible = false;
            insertarCategoria();
        }

        private void evento_eliminar_categoria(object sender, EventArgs e)
        {

            id_grupo = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            eliminarCategoria();  
        }

        private void ver_producto_por_grupo()
        {
            btnRegresar.Visible = true;
            pnCategoria.Visible = false;
            pnAgregarCategoria.Visible = false;
            dibujarProducto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            agregarImagen();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (valido2)
            {
                errorProviderNombreCategoria.SetError(txtCategoria, "");
                insertarCategoria();
                pnAgregarCategoria.Visible = false;
                dibujarCategoria();
            }
            
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            pnAgregarCategoria.Visible = false;
            pnCategoria.Visible = true;
            dibujarCategoria();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
            //this.productosTableAdapter1.Fill(this.dataSetProductos.Productos);
            // TODO: esta línea de código carga datos en la tabla 'tiendaPaletasDataSet.Productos' Puede moverla o quitarla según sea necesario.
            // this.productosTableAdapter.Fill(this.tiendaPaletasDataSet.Productos);
            dibujarCategoria();
            btnAgregarProducto.SendToBack();
            btnAgregarProducto2.BringToFront();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            if (valido)
            {
                insertarProducto();
                limpiarCamposProd();
                dibujarProducto();
            }
            limpiarCamposProd();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            borrarErrorCamposProd();
            btnAgregarProducto2.SendToBack();
            btnAgregarProducto.BringToFront();
            limpiarCamposProd();
            btnAgregarProducto.Text = "Agregar";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnRegresar.Visible = false;
            pnProductos.Visible = false;
            pnAgregarCategoria.Visible = false;
            pnCategoria.Visible = true;
            dibujarCategoria();           
            limpiarCamposProd();
            DataTable dtll = (DataTable)dataGridViewProd.DataSource;
            dtll.Clear();

        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            btnRegresar.Visible = true;
            pnCategoria.Visible = false;
            pnAgregarCategoria.Dock = DockStyle.Fill;
            pnAgregarCategoria.Visible = true;
            btnAgregarProducto.Text = "Agregar";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            agregarImagen();
        }

        private void pnContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxProd_Click(object sender, EventArgs e)
        {
            agregarImagenProd();
        }

        private void DataGridViewProd_SelectionChanged(object sender, EventArgs e)
        {
                    pnDatosProducto.Visible = true;
                     if (dataGridViewProd.Rows.Count > 0 && dataGridViewProd.SelectedRows.Count > 0){
                         llenarCamposProd();
                         btnAgregarProducto.Text = "Actualizar";
                     }
            //llenarCamposProd();
        }




        private void llenarCamposProd()
        {

            try
            {
                if (flowPnCategorias.Focused)
                {
                    dataGridViewProd.Rows.Clear();
                }
                //else 
                if (pnProductos.Visible && dataGridViewProd.Rows.Count >= 0)
                {       
                                 
                    txtProducto.Text = dataGridViewProd.SelectedRows[0].Cells[1].Value.ToString();
                    txtPrecio.Text = dataGridViewProd.SelectedRows[0].Cells[3].Value.ToString();
                    txtCantidad.Text = dataGridViewProd.SelectedRows[0].Cells[4].Value.ToString();
                    cbTamañoProducto.SelectedItem = dataGridViewProd.SelectedRows[0].Cells[5].Value.ToString();
                    
                }
            }
            
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void limpiarCamposProd()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cbTamañoProducto.SelectedItem = null;
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            
            eliminarProducto();
        }

        

        private void borrarErrorCamposProd()
        {
            errorProviderNombreProducto.SetError(txtProducto, "");
            errorProviderPrecioProducto.SetError(txtPrecio, "");
            errorProviderCantidadProducto.SetError(txtCantidad, "");
        }

        

        private void txtProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            String pattern = "^[A-Za-z ]+$";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(txtProducto.Text))
            {
                errorProviderNombreProducto.SetError(txtProducto, "");
                valido = true;
            }
            else
            {
                errorProviderNombreProducto.SetError(txtProducto, "Inserte un nombre correcto");
                valido = false;
            }
            
                       
        }

        private void txtPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            float precio;
            if(!float.TryParse(txtPrecio.Text, out precio))
            {
                errorProviderPrecioProducto.SetError(txtPrecio, "Inserte un precio con solo números, ejemplo: 12.50");
                valido = false;
            }
            else
            {
                errorProviderPrecioProducto.SetError(txtPrecio, "");
                valido = true;
            }
        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int cant;
            if(!int.TryParse(txtCantidad.Text, out cant))
            {
                errorProviderCantidadProducto.SetError(txtCantidad, "Inserte una cantidad correcta, ejemplo: 24");
                valido = false;
            }
            else
            {
                errorProviderCantidadProducto.SetError(txtCantidad, "");
                valido = true;
            }
        }

        private void txtCategoria_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            String pattern = "^[A-Za-z ]+$";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(txtCategoria.Text))
            {
                errorProviderNombreCategoria.SetError(txtCategoria, "");
                valido2 = true;
            }
            else
            {
                errorProviderNombreCategoria.SetError(txtCategoria, "Inserte un nombre correcto");
                valido2 = false;
            }
        }
    }
}
