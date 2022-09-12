using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD___MYSQL
{
    public partial class frmArticulos : Form
    {
       
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.DarkSeaGreen;
            btnNuevo.ForeColor = Color.Black;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.SteelBlue;
            btnNuevo.ForeColor = Color.White;
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.BackColor = Color.DarkSeaGreen;
            btnActualizar.ForeColor = Color.Black;
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.DarkSeaGreen;
            btnEliminar.ForeColor = Color.Black;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.ForeColor = Color.White;
        }

        private void btnReporte_MouseHover(object sender, EventArgs e)
        {
            btnReporte.BackColor = Color.DarkSeaGreen;
            btnReporte.ForeColor = Color.Black;
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            btnReporte.BackColor = Color.SteelBlue;
            btnReporte.ForeColor = Color.White;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.ForeColor = Color.White;
        }

        //MIS MÉTODOS
        #region "MIS METODOS"
        private void listadoArticulos(string filtro)
        {
            clsArticulos objArticulos = new clsArticulos();
            dgvArticulos.DataSource = objArticulos.listarArticulos(filtro);
            this.formatoArticulos();
        }
        private void formatoArticulos()
        {
            dgvArticulos.Columns[0].Width = 80;
            dgvArticulos.Columns[0].HeaderText = "CÓDIGO";
            dgvArticulos.Columns[1].Width = 250;
            dgvArticulos.Columns[1].HeaderText = "ARTÍCULO";
            dgvArticulos.Columns[2].Width = 150;
            dgvArticulos.Columns[2].HeaderText = "MARCA";
            dgvArticulos.Columns[3].Width = 80;
            dgvArticulos.Columns[3].HeaderText = "STOCK ACTUAL";
            dgvArticulos.Columns[4].Visible = false;
            dgvArticulos.Columns[5].Visible = false;
            dgvArticulos.Columns[6].Width = 150;
            dgvArticulos.Columns[6].HeaderText = "CATEGORÍA";
            dgvArticulos.Columns[7].Width = 80;
            dgvArticulos.Columns[7].HeaderText = "MEDIDA";
            dgvArticulos.Columns[8].Visible = false;
            dgvArticulos.Columns[9].Visible = false;
        }
        private void estadoTexto(bool estado)
        {
            txtDescripcionArticulo.ReadOnly = !estado;
            txtMarca.ReadOnly = !estado;
            txtStockActual.ReadOnly = !estado;
            txtDescripcionArticulo.Enabled = estado;
            txtMarca.Enabled = estado;
            txtStockActual.Enabled = estado;
            txtDescripcionArticulo.Focus();
        }
        private void estadoBotonesProceso(bool estado)
        {
            btnLupaUM.Enabled = estado;
            btnLupaCategoria.Enabled = estado;
            btnCancelar.Visible = estado;
            btnGuardar.Visible = estado;
            //Otros detalles
            txtBuscar.ReadOnly = estado;
            btnBuscar.Enabled = !estado;
            dgvArticulos.Enabled = !estado;
        }
        private void estadoBotonesPrincipales(bool estado)
        {
            btnNuevo.Enabled = estado;
            btnActualizar.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnReporte.Enabled = estado;
            btnSalir.Enabled = estado;
        } 
        private void limpiarTexto()
        {
            txtDescripcionArticulo.Text = "";
            txtMarca.Text = "";
            txtMedida.Text = "";
            txtCategoria.Text = "";
            txtStockActual.Text = "";
        }
        #endregion
        //FIN MIS MÉTODOS
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            this.listadoArticulos("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listadoArticulos("%"+txtBuscar.Text.Trim()+"%");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.estadoTexto(true);
            this.estadoBotonesProceso(true);
            this.estadoBotonesPrincipales(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.limpiarTexto();
            this.estadoTexto(false);
            this.estadoBotonesProceso(false);
            this.estadoBotonesPrincipales(true);
            txtBuscar.Focus();
        }
    }
}
