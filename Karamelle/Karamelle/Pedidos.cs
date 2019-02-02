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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }
        Negocio.Pedidos ped = new Negocio.Pedidos();
        Negocio.Detalle det = new Negocio.Detalle();
        private void añadirFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvCargo.Rows.Add("", "","", Convert.ToInt32(0), "");
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvCargo.Rows.RemoveAt(dgvCargo.CurrentRow.Index);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }
        private void Cargardatos(int id)
        {
            try
            {
                dgvCargo.Rows.Clear();
                foreach (DataRow fila in det.CargarDetallePedido(Convert.ToInt32(txtIDDecorador.Text)).Rows)
                {
                    dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3].ToString()), fila[4].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                ListaCliente listac = new ListaCliente();
                listac.ShowDialog();
                if (listac.DialogResult == DialogResult.OK)
                {

                    txtIdPaciente.Text = listac.id.ToString() ;
                    txtNombre.Text = listac.cliente;
                    txtNit.Text = listac.nit;
                }
            }
        }

        private void txtDecorador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                ListaDecorador listac = new ListaDecorador();
                listac.ShowDialog();
                if (listac.DialogResult == DialogResult.OK)
                {
                    txtIDDecorador.Text = listac.id.ToString();
                    txtDecorador.Text = listac.decorador;
                }
            }
        }

        private void txtPastelero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                ListaPastelero listac = new ListaPastelero();
                listac.ShowDialog();
                if (listac.DialogResult == DialogResult.OK)
                {
                    txtIDPastelero.Text = listac.id.ToString();
                    txtPastelero.Text = listac.pastelero;
                }
            }
        }

        private void dgvCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                if (dgvCargo.CurrentCell == dgvCargo.CurrentRow.Cells[1])
                { 
                    ListaPastel list = new ListaPastel();
                    list.ShowDialog();
                    if (list.DialogResult == DialogResult.OK)
                    {
                        dgvCargo.CurrentRow.Cells[2].Value = list.tamaño;
                        dgvCargo.CurrentCell.Value = list.pastel.ToString();
                        dgvCargo.CurrentRow.Cells[0].Value = list.id;

                    }
                }
                if (dgvCargo.CurrentCell == dgvCargo.CurrentRow.Cells[0])
                {
                    ListaPastel list = new ListaPastel();
                    list.ShowDialog();
                    if (list.DialogResult == DialogResult.OK)
                    {
                        dgvCargo.CurrentRow.Cells[2].Value = list.tamaño;
                        dgvCargo.CurrentRow.Cells[1].Value = list.pastel.ToString();
                        dgvCargo.CurrentRow.Cells[0].Value = list.id;

                    }
                }
            }
        }
        private bool Verificar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Inserte un Cliente correcto");
                return false;
            }
            if (txtPastelero.Text == "")
            {
                MessageBox.Show("Inserte un Pastelero correcto");
                return false;
            }
            if (txtDecorador.Text == "")
            {
                MessageBox.Show("Inserte un Decorador correcto");
                return false;
            }
            if (dgvCargo.Rows.Count == 0)
            {
                 MessageBox.Show("No hay detalle Insertado");
                return false;
            }
            foreach (DataGridViewRow Row in dgvCargo.Rows)
            {
                if (Row.Cells[0].Value == "")
                {
                    MessageBox.Show("Falta Campo Pastel");
                    return false;
                }
                if (Row.Cells[3].Value == "" || Row.Cells[3].Value == "0" )
                {
                    MessageBox.Show("Falta Cantidad");
                    return false;
                }
            }
            

            return true;
        }
        private bool Validar()
        {
            ped.ID = ped.IDPedidoMax();
            ped.IDCliente = Convert.ToInt32(txtIdPaciente.Text);
            ped.IDDecorador = Convert.ToInt32(txtIDDecorador.Text);
            ped.IDPastelero = Convert.ToInt32(txtIDPastelero.Text);
            ped.Nit = txtNit.Text;
            ped.FechaEntrega = dtFecha.Value.Date;
            return true;
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
                    ped.GuardarPedido();
                    int c = 1;
                    foreach (DataGridViewRow Row in dgvCargo.Rows)
                    {
                        det.IDPedido = ped.ID;
                        det.IDPastel = Convert.ToInt32(Row.Cells[0].Value);
                        det.Tamaño = Row.Cells[2].Value.ToString();
                        det.Cantidad = Convert.ToInt32(Row.Cells[3].Value);
                        det.Decoracion = Row.Cells[4].Value.ToString();
                        det.IDDetalle = c;
                        det.GuardarDetalle();
                        c++;
                    }
                    
                    MessageBox.Show("Registrado");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
