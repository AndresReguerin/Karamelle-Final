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
    public partial class ListaPedidos : Form
    {
        public ListaPedidos()
        {
            InitializeComponent();
        }
        public int id;
        Negocio.Pedidos ped = new Negocio.Pedidos();
        private void ListaPedidos_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in ped.CargarPedido().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), fila[4].ToString(), fila[5].ToString(), fila[6].ToString(), fila[7].ToString(), fila[8].ToString(), fila[9].ToString(), fila[10].ToString());
            }
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCargo.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPedido f = new VerPedido();
            f.id = this.id;
            f.ShowDialog();
            cargardatos();
           
        }

        private void actualizarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarPedido f = new ActualizarPedido();
            f.id = this.id;
            f.ShowDialog();
            cargardatos();
        }
    }
}
