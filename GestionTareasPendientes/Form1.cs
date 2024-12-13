using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }

        private void txtTareas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string texto = txtTareas.Text;
            if (texto != "") { 
                lstTareas.Items.Add(texto);
                txtTareas.Text = "";
                txtTareas.Focus();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
        }
    }
}
