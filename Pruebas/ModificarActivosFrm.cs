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
    public partial class ModificarActivosFrm : Form
    {
        string noControl;
        int posicion;
        public ModificarActivosFrm()
        {
            InitializeComponent();
        }

        ActivosFijos activos = new ActivosFijos();

        private void ModificarActivosFrm_Load(object sender, EventArgs e)
        {
            dgvActivos.DataSource = activos.MostrarActivos();
            btnModificar.Enabled = false;
        }

        void limpiar()
        {
            btnModificar.Enabled = false;
            txtNoControlInv.Text = string.Empty;
            rtxtDescripcion.Text = string.Empty;
            txtImporte.Text = string.Empty;
            rtxtCambios.Text = string.Empty;
            rtxtMonitoreo.Text = string.Empty;
            txtRFC.Text = string.Empty;
        }

        private void dgvActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvActivos.CurrentRow.Index;
            txtNoControlInv.Text = dgvActivos[0, posicion].Value.ToString();
            noControl = dgvActivos[0, posicion].Value.ToString();
            rtxtDescripcion.Text = dgvActivos[1, posicion].Value.ToString();
            txtImporte.Text = dgvActivos[2, posicion].Value.ToString();
            rtxtCambios.Text = dgvActivos[3, posicion].Value.ToString();
            rtxtMonitoreo.Text = dgvActivos[4, posicion].Value.ToString();
            txtRFC.Text = dgvActivos[5, posicion].Value.ToString();
            btnModificar.Enabled = true;
            txtNoControlInv.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string noControlMod = txtNoControlInv.Text;
            string descripcion = rtxtDescripcion.Text;
            string importe = txtImporte.Text;
            string cambios = rtxtCambios.Text;
            string monitoreo = rtxtMonitoreo.Text;
            string rfc = txtRFC.Text;

            activos.Actualizar(noControl,noControlMod,descripcion, importe, cambios, monitoreo, rfc);

            dgvActivos.DataSource = activos.MostrarActivos();
            btnModificar.Enabled = false;
            limpiar();
        }
    }
}
