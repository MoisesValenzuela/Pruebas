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
    public partial class RegistroUsuariosFrm : Form
    {
        public RegistroUsuariosFrm()
        {
            InitializeComponent();
        }

        private List<RolUsuario> ComboRol()
        {
            using(PruebaEntities db = new PruebaEntities())
            {
                return db.RolUsuario.ToList();
            }
        }
        
        private void CargarCombo()
        {
            try
            {
                var Lst = ComboRol();
                cBoxRol.DataSource = Lst;
                cBoxRol.DisplayMember = "RolNombre";
                cBoxRol.ValueMember = "IdRol";  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void GuardarUsuario(Usuario pUsuario)
        {
            try
            {
                using(PruebaEntities db = new PruebaEntities())
                {
                    db.Usuario.Add(pUsuario);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void RegistroUsuariosFrm_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Usuario usuarioEnt = new Usuario();
            usuarioEnt.Nombre = txtnomusu.Text;
            usuarioEnt.Apellido = txtapeusu.Text;
            usuarioEnt.Usuario1 = txtusu.Text;
            usuarioEnt.Contraseña = txtcontrasena.Text;
            usuarioEnt.RolId = (int)cBoxRol.SelectedValue;
            GuardarUsuario(usuarioEnt);
            MessageBox.Show("Usuario Registrado");
        }
    }
}
