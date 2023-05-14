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
    public partial class AgregarActivosManual : Form
    {
        public AgregarActivosManual()
        {
            InitializeComponent();
        }

        ActivosFijos activos = new ActivosFijos();

        private void AgregarActivosManual_Load(object sender, EventArgs e)
        {
            dgvActivos.DataSource = activos.MostrarActivos();
        }

        void limpiar()
        {
            txtNoControlInv.Text = string.Empty;
            rtxtDescripcion.Text = string.Empty;
            txtImporte.Text = string.Empty;
            rtxtCambios.Text = string.Empty;
            rtxtMonitoreo.Text = string.Empty;
            txtRFC.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string noControl = txtNoControlInv.Text;
            string descripcion = rtxtDescripcion.Text;
            string importe = txtImporte.Text;
            string cambios = rtxtCambios.Text;
            string monitoreo = rtxtMonitoreo.Text;
            string rfc = txtRFC.Text;

            activos.AgregarManual(noControl, descripcion, importe, cambios, monitoreo, rfc);

            dgvActivos.DataSource = activos.MostrarActivos();
            limpiar();
        }
    }
}
