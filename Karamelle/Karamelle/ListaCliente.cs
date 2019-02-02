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
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
        }
        Negocio.Persona per = new Negocio.Persona();
        DataTable dt = new DataTable();
        DataView dw;
        public int id;
        public string cliente;
        public string nit;
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ListaCliente_Load(object sender, EventArgs e)
        {
            dw = new DataView(per.CargarCliente());
            dgvCargo.DataSource = dw;

            dgvCargo.Columns[0].Width = 70;
            dgvCargo.Columns[1].Width = 200;
            dgvCargo.Columns[2].Width = 100;
            dgvCargo.Columns[3].Width = 100;
            dgvCargo.Columns[4].Width = 100;

            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Cliente";
            dgvCargo.Columns[2].HeaderText = "Telefono";
            dgvCargo.Columns[3].HeaderText = "CI";
            dgvCargo.Columns[4].HeaderText = "NIT";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dw.RowFilter = "Cliente like '%" + this.txtBuscar.Text + "%'";
            dgvCargo.DataSource = dw;

            dgvCargo.Columns[0].Width = 70;
            dgvCargo.Columns[1].Width = 200;
            dgvCargo.Columns[2].Width = 100;
            dgvCargo.Columns[3].Width = 100;
            dgvCargo.Columns[4].Width = 100;

            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Cliente";
            dgvCargo.Columns[2].HeaderText = "Telefono";
            dgvCargo.Columns[3].HeaderText = "CI";
            dgvCargo.Columns[4].HeaderText = "NIT";
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCargo.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    cliente = dgvCargo.CurrentRow.Cells[1].Value.ToString();
                    nit = (dgvCargo.CurrentRow.Cells[4].Value.ToString());
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }

        private void lblSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
