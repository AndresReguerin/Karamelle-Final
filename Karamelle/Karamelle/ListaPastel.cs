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
    public partial class ListaPastel : Form
    {
        public ListaPastel()
        {
            InitializeComponent();
        }
        Negocio.Pastel per = new Negocio.Pastel();
        DataTable dt = new DataTable();
        DataView dw;
        public int id;
        public string pastel;
        public string tamaño;
        private void ListaPastel_Load(object sender, EventArgs e)
        {
            dw = new DataView(per.CargarPastel());
            dgvCargo.DataSource = dw;

            dgvCargo.Columns[0].Width = 100;
            dgvCargo.Columns[1].Width = 150;
            dgvCargo.Columns[2].Width = 100;
            dgvCargo.Columns[3].Width = 100;
            dgvCargo.Columns[4].Width = 100;

            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Pastel";
            dgvCargo.Columns[2].HeaderText = "IDTamabo";
            dgvCargo.Columns[3].HeaderText = "Tamaño";
            dgvCargo.Columns[4].HeaderText = "Capacidad";
            dgvCargo.Columns[2].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dw.RowFilter = "Pastel like '%" + this.txtBuscar.Text + "%'";
            dgvCargo.DataSource = dw;

            dgvCargo.Columns[0].Width = 100;
            dgvCargo.Columns[1].Width = 150;
            dgvCargo.Columns[2].Width = 100;
            dgvCargo.Columns[3].Width = 100;
            dgvCargo.Columns[4].Width = 100;

            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Pastel";
            dgvCargo.Columns[2].HeaderText = "IDTamabo";
            dgvCargo.Columns[3].HeaderText = "Tamaño";
            dgvCargo.Columns[4].HeaderText = "Capacidad";
            dgvCargo.Columns[2].Visible = false;
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCargo.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    pastel = dgvCargo.CurrentRow.Cells[1].Value.ToString();
                    tamaño = (dgvCargo.CurrentRow.Cells[3].Value.ToString());
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }

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
    }
}
