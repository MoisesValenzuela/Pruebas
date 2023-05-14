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
    public partial class MenuFrm : Form
    {
        int IdRol, IdUsu;

        public MenuFrm()
        {
            InitializeComponent();
        }
        public MenuFrm(string pUser, int pIdRol, int pIdUsu)
        {
            InitializeComponent();
            IdRol = pIdRol;
            IdUsu = pIdUsu;
        }

        private List<Permiso> SelectOption(int pId)
        {
            using(PruebaEntities db = new PruebaEntities())
            {
                return db.Permiso.Where(i=>i.RolUsuId==pId).ToList();
            }
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            ConsultarRol(activosToolStripMenuItem);
            ConsultarRol(reportesToolStripMenuItem);
            ConsultarRol(usuariosToolStripMenuItem);
            ConsultarRol(administraciónToolStripMenuItem);
        }

        private void ConsultarRol(ToolStripMenuItem pCon)
        {
            var LstOp = SelectOption(IdRol);
            foreach(ToolStripMenuItem c in pCon.DropDownItems)
            {
                foreach (Permiso opc in LstOp)
                {
                    if (opc.OpcionId == Convert.ToInt32(c.Tag))
                    {
                        if (!opc.Permitido)
                        {
                            c.Enabled = false;
                        }
                    }
                }
            }
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroUsuariosFrm altausu = new RegistroUsuariosFrm();
            altausu.Show();
        }

        private void altaRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroRolFrm altarol = new RegistroRolFrm();
            altarol.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizacionActivosFrm visactivosfijos = new VisualizacionActivosFrm();
            visactivosfijos.Show();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarActivosFrm modificarActivos = new ModificarActivosFrm();
            modificarActivos.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarActivos eliminarActivos = new EliminarActivos();
            eliminarActivos.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarActivosManual agregarActivosManual = new AgregarActivosManual();
            agregarActivosManual.Show();
        }

        private void resguardosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResguardosFrm resguardo = new ResguardosFrm();
            resguardo.Show();
        }
    }
}
