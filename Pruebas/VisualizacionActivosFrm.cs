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
    public partial class VisualizacionActivosFrm : Form
    {
        public VisualizacionActivosFrm()
        {
            InitializeComponent();
        }

        ActivosFijos activos = new ActivosFijos();

        private void VisualizacionActivosFrm_Load(object sender, EventArgs e)
        {
            dgvActivos.DataSource = activos.MostrarActivos();
        }
    }
}
