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
    public partial class Tamaño : Form
    {
        public Tamaño()
        {
            InitializeComponent();
        }
        Negocio.Tamaño pas = new Negocio.Tamaño();
        private void Tamaño_Load(object sender, EventArgs e)
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

            return true;
        }
        private bool Validar()
        {
            pas.ID = pas.IDTamañoMax();
            pas.Descripcion = txtNombre.Text;
            pas.Capacidad = Convert.ToInt32(txtCapacidad.Text);
            return true;
        }
        private bool Validaractualizar()
        {
            pas.ID = Convert.ToInt32(txtID.Text);
        
            pas.Descripcion = txtNombre.Text;
            pas.Capacidad = Convert.ToInt32(txtCapacidad.Text);
            return true;

        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in pas.CargarTamaño().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCapacidad.Text = "";
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
                    pas.GuardarTamaño();

                    MessageBox.Show("Registrado");
                    cargardatos();
                }
            }
            catch (Exception)
            {

                throw;
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
                    pas.ActualizarTamaño();
                    MessageBox.Show("Actualizado");
                    cargardatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
                    txtCapacidad.Text = dgvCargo.CurrentRow.Cells[2].Value.ToString();
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
                    pas.Anular(Convert.ToInt32(txtID.Text));
                    cargardatos();
                }
                else
                {
                    MessageBox.Show("Seleccione un Tamaño");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
