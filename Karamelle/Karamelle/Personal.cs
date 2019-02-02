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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }
        Negocio.Cargo carg = new Negocio.Cargo();
        Persona persona = new Persona();
        Usuario user = new Usuario();
        Negocio.Opciones op = new Negocio.Opciones();
       // Validar val = new Validar();

        private bool Verificar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Inserte un nombre correcto");
                return false;
            }
            if (cmbCombo.Text == " ")
            {
                MessageBox.Show("Seleccione un Cargo");
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Inserte un apellido correcto");
                return false;
            }
            if (txtCI.Text == "")
            {
                txtCI.Text = "0";
            }
          
            if (txtLogin.Text == " ")
            {
                MessageBox.Show("Inserte un nombre de usuario /Login correcto");
                return false;
            }
            if (txtPassword.Text == " ")
            {
                MessageBox.Show("Inserte un Password correcto");
                return false;
            }
            return true;
        }
        private bool Validar()
        {
            persona.ID = persona.IDPersonaMax();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Cargo = (cmbCombo.Text.ToString());
            persona.CI = txtCI.Text;
            persona.Telefono = txtTelefono.Text;
            user.ID = persona.ID;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;

            return true;
        }
        private bool Validaractualizar()
        {
            persona.ID = Convert.ToInt32(txtID.Text);
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Cargo = (cmbCombo.Text.ToString());
            persona.CI = txtCI.Text;
            persona.Telefono = txtTelefono.Text;
            user.ID = persona.ID;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;

            return true;
        }
        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Personal_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in persona.CargarPersonal().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), fila[4].ToString(), fila[5].ToString(), fila[6].ToString(),fila[7].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCI.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtPassword.Text = "";
            txtLogin.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verificar())
                {
                    return;
                }
                if (Validar())
                {
                    persona.GuardarPersona();
                    persona.GuardarPersonal();
                    user.GuardarUsuario();
                    for (int i = 1; i <= 9; i++)
                    {
                        op.GuardarAutorizaciones(user.ID, i);
                    }
                    MessageBox.Show("Registrado");
                    cargardatos();
                    txtID.Text = persona.ID.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCargo.CurrentRow != null)
                {
                    txtID.Text = dgvCargo.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dgvCargo.CurrentRow.Cells[1].Value.ToString();
                    txtApellido.Text = dgvCargo.CurrentRow.Cells[2].Value.ToString();
                    txtTelefono.Text = dgvCargo.CurrentRow.Cells[3].Value.ToString();
                    txtCI.Text = dgvCargo.CurrentRow.Cells[4].Value.ToString();
                    cmbCombo.Text = dgvCargo.CurrentRow.Cells[5].Value.ToString();
                    txtLogin.Text = dgvCargo.CurrentRow.Cells[6].Value.ToString();
                    txtPassword.Text = dgvCargo.CurrentRow.Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verificar())
                {
                    return;
                }
                if (Validaractualizar())
                {
                    persona.ActualizarPersona();
                    persona.ActualizarPersonal();
                    user.ActualizarUsuario();
                    MessageBox.Show("Actualizado");
                    cargardatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    persona.Anular(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    MessageBox.Show("Seleccione un Personal");
                }
               
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
