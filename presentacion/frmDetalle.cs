using domino;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
        public frmDetalle()
        {
            InitializeComponent();
        }
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://img1.freepng.es/20180413/ofw/kisspng-samsung-galaxy-s7-edge-touchscreen-screen-protecto-cell-phone-5ad15123a64ea8.9713958015236672356812.jpg");
            }
        }
        private void frmDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio elementoMarca = new MarcaNegocio();
            CategoriaNegocio elementoCategoria = new CategoriaNegocio();
            try
            {


                
                if (articulo != null)
                {
                    lblTextoCodigo.Text = articulo.Codigo;
                    lblTextoNombre.Text = articulo.Nombre;
                    lblTextoDescripcion.Text = articulo.Descripcion;                    
                    cargarImagen(articulo.imagenUrl);
                    lblTextoPrecio.Text = articulo.Precio.ToString();
                    lblTextoMarca.Text = articulo.Marca.Descripcion;
                    lblTextoCategoria.Text = articulo.Categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
