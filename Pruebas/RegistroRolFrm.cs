using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class RegistroRolFrm : Form
    {
        public RegistroRolFrm()
        {
            InitializeComponent();
        }

        private void GuardarRol()
        {
            try
            {
                using (PruebaEntities db = new PruebaEntities())
                {
                    RolUsuario rol = new RolUsuario();
                    rol.RolNombre = txtnomrol.Text.ToUpper().Trim();
                    db.RolUsuario.Add(rol);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void GuardarPermiso(Permiso pPermiso)
        {
            try
            {
                using(PruebaEntities db = new PruebaEntities()) 
                { 
                    db.Permiso.Add(pPermiso);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private int UltimoRegistro()
        {
            using(PruebaEntities db = new PruebaEntities())
            {
                var ultimo = (from c in db.RolUsuario
                              orderby c.IdRol descending
                              select c.IdRol).FirstOrDefault();
                return ultimo;
            }
        }

        private void CheckRol()
        {
            Permiso permisoentidad = new Permiso();
            int id = UltimoRegistro();
            foreach (Control chk in panel1.Controls)
            {
                permisoentidad.RolUsuId = id;
                if(chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        permisoentidad.OpcionId = Convert.ToInt32(chk.Tag);
                        permisoentidad.Permitido = true;
                        GuardarPermiso(permisoentidad);
                    }
                    else
                    {
                        permisoentidad.OpcionId = Convert.ToInt32(chk.Tag);
                        permisoentidad.Permitido = false;
                        GuardarPermiso(permisoentidad);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtnomrol.Text = string.Empty;
            txtnomrol.Focus();
            foreach (Control chk in panel1.Controls)
            {
                if(chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        (((CheckBox)chk).Checked) = false;
                    }
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            GuardarRol();
            CheckRol();
            Limpiar();
            MessageBox.Show("Rol de Usuario guardado");
        }
    }
}