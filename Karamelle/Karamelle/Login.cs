using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Karamelle.Negocio;

namespace Karamelle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Usuario login = new Usuario();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                login.Login = txtUsuario.Text;
                login.Password = txtContrasena.Text;
                int id = login.Loguearse();
                if (id == -1)
                {
                    MessageBox.Show("Usuario y/o Contraseña erronea!!", "Credenciales erroeneas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.IDUsuario = id;
                Program.Usuario = login.Login;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
