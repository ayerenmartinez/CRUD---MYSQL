using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
