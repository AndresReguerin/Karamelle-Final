using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karamelle
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        Negocio.Persona persona = new Negocio.Persona();

        private void Cliente_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
        private bool Verificar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Inserte un nombre correcto");
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Inserte un Apellido correcto");
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Inserte un Telefono correcto");
                return false;
            }
            if (txtCI.Text == "")
            {
                txtCI.Text = "0";
            }

            return true;
        }
        private bool Validar()
        {
            persona.ID = persona.IDPersonaMax();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.CI = txtCI.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Nit = txtNit.Text;



            return true;
        }
        private bool Validaractualizar()
        {
            persona.ID = Convert.ToInt32(txtID.Text);
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.CI = txtCI.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Nit = txtNit.Text;

            return true;
        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in persona.CargarCliente().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), fila[4].ToString(), fila[5].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCI.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtNit.Text = "";

           
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
                    persona.GuardarCliente();
                   
                    MessageBox.Show("Registrado");
                    cargardatos();
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
                    txtNit.Text = dgvCargo.CurrentRow.Cells[5].Value.ToString();

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
                    persona.ActualizarCliente();
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
                persona.Anular(Convert.ToInt32(txtID.Text));
                cargardatos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show( ex.ToString());
            }
        }
    }
}
