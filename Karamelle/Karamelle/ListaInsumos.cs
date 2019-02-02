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
    public partial class ListaInsumos : Form
    {
        public ListaInsumos()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataView dw;
        Negocio.Insumos INS = new Negocio.Insumos();
        public int id;
        public string insumo;
        public string medida;
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
        
        private void ListaInsumos_Load(object sender, EventArgs e)
        {
            dw = new DataView(INS.CargarInsumo());
            dgvCargo.DataSource = dw;

            dgvCargo.Columns[0].Width = 100;
            dgvCargo.Columns[1].Width = 150;
            dgvCargo.Columns[2].Width = 100;
            

            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Insumo";
            dgvCargo.Columns[2].HeaderText = "Medida";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dw.RowFilter = "Descrip like '%" + this.txtBuscar.Text + "%'";

            dgvCargo.DataSource = dw;
            dgvCargo.Columns[0].Width = 100;
            dgvCargo.Columns[1].Width = 150;
            dgvCargo.Columns[2].Width = 100;
            
            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Insumo";
            dgvCargo.Columns[2].HeaderText = "Medida";
            
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCargo.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    insumo = dgvCargo.CurrentRow.Cells[1].Value.ToString();
                    medida = (dgvCargo.CurrentRow.Cells[2].Value.ToString());
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }
    }
}
