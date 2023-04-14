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
    public partial class LoginFrm : Form
    {
        int IdRol, IdUsu;
        string nomUsu;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private List<Usuario> BuscarUsuario(string pUser, string pContra)
        {
            try
            {
                using(PruebaEntities db = new PruebaEntities())
                {
                    return db.Usuario.Where(us=>us.Usuario1==pUser
                                            &&us.Contraseña==pContra)
                                            .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                throw;
            }
        }

        private bool ValidarCampos()
        {
            var usuario = BuscarUsuario(txtusuario.Text,txtcontraseña.Text);
            foreach (var usu in usuario)
            {
                IdRol = usu.RolId;
                IdUsu = usu.IdUsuario;
                nomUsu = usu.Usuario1;
            }
            if (txtusuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Usuario");
                txtusuario.Focus();
                return false;
            }
            else if (txtcontraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Contraseña");
                txtcontraseña.Focus();
                return false;
            }
            else if (usuario.Count <=0)
            {
                MessageBox.Show("Usuario no registrado");
                return false;
            }
            return true;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MenuFrm menu = new MenuFrm(nomUsu, IdRol, IdUsu);
                menu.Show();
                this.Hide();
            }  
        }
    }
}
