using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class EliminarActivos : Form
    {
        int posicion;
        public EliminarActivos()
        {
            InitializeComponent();
        }

        ActivosFijos activos = new ActivosFijos();

        private void EliminarActivos_Load(object sender, EventArgs e)
        {
            dgvActivos.DataSource = activos.MostrarActivos();
            btnEliminar.Enabled = false;
        }

        private void dgvActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvActivos.CurrentRow.Index;
            txtNoControlInv.Text = dgvActivos[0, posicion].Value.ToString();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string noControlInv = txtNoControlInv.Text;

            activos.Eliminar(noControlInv);

            dgvActivos.DataSource = activos.MostrarActivos();
            btnEliminar.Enabled = false;
            txtNoControlInv.Text = string.Empty;
        }
    }
}
