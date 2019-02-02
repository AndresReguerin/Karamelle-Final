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
    public partial class Insumo : Form
    {
        public Insumo()
        {
            InitializeComponent();
        }
        Negocio.Insumos pas = new Negocio.Insumos();
        private void Insumo_Load(object sender, EventArgs e)
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
            if (txtUnidad.Text == "")
            {
                MessageBox.Show("Inserte una Unidad de Medidad ");
                return false;
            }


            return true;
        }
        private bool Validar()
        {
            pas.ID = pas.IDInsumoMax();
            pas.Nombre = txtNombre.Text;
            pas.Unidad = txtUnidad.Text;
            return true;
        }
        private bool Validaractualizar()
        {
            pas.ID = Convert.ToInt32(txtID.Text);
            pas.Nombre = txtNombre.Text;
            pas.Unidad = txtUnidad.Text;
            return true;

        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in pas.CargarInsumo().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
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
                    pas.GuardarInsumo();

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
                    pas.ActualizarInsumo();
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
                    txtUnidad.Text = dgvCargo.CurrentRow.Cells[2].Value.ToString();
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
                    MessageBox.Show("Seleccione un Insumo");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
