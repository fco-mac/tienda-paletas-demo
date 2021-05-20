using System.Windows.Forms;

namespace TiendaPaletas.Views
{
    public partial class FormPadreAdmin : Form
    {
        public FormPadreAdmin()
        {
            InitializeComponent();
        }

        private void abrirFormCategorias(object formCat)
        {
            if(this.panelContenido.Controls.Count > 0)
            {
                this.panelContenido.Controls.RemoveAt(0);
            }
            Form fc = formCat as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fc);
            this.panelContenido.Tag = fc;
            fc.Show();
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {
            abrirFormCategorias(new Categorias());
        }
    }
}
