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
    public partial class ListaIngredientes : Form
    {
        public ListaIngredientes()
        {
            InitializeComponent();
        }
        Negocio.Pastel pas = new Negocio.Pastel();
        Negocio.ListaIngrediente lista = new Negocio.ListaIngrediente();
        private void dgvCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                if (dgvCargo.CurrentCell == dgvCargo.CurrentRow.Cells[1])
                {
                    ListaInsumos list = new ListaInsumos();
                    list.ShowDialog();
                    if (list.DialogResult == DialogResult.OK)
                    {
                        dgvCargo.CurrentRow.Cells[3].Value = list.medida; 
                        dgvCargo.CurrentCell.Value = list.insumo.ToString();
                        dgvCargo.CurrentRow.Cells[0].Value = list.id;
                        
                    }
                }
                if (dgvCargo.CurrentCell == dgvCargo.CurrentRow.Cells[0])
                {
                    ListaInsumos list = new ListaInsumos();
                    list.ShowDialog();
                    if (list.DialogResult == DialogResult.OK)
                    {
                        dgvCargo.CurrentRow.Cells[3].Value = list.medida;
                        dgvCargo.CurrentRow.Cells[1].Value = list.insumo.ToString();
                        dgvCargo.CurrentRow.Cells[0].Value = list.id;

                    }
                }
            }
        }

        private void añadirFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgvCargo.Rows.Add("","",Convert.ToDecimal(0),"");

        }
        private void Cargardatos(int id)
        {
            try
            {
                dgvCargo.Rows.Clear();
                foreach (DataRow fila in lista.CargarLista(id).Rows)
                {
                    dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), Convert.ToDecimal(fila[2].ToString()), fila[3].ToString());
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvCargo.Rows.RemoveAt(dgvCargo.CurrentRow.Index);
        }

        private void ListaIngredientes_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "IDPastel";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = pas.CargarPastel();   
        }
        private void Validar()
        {
            lista.IDPastel = Convert.ToInt32(comboBox1.SelectedValue);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Validar();
            lista.EliminarLista();
           
            foreach (DataGridViewRow row in dgvCargo.Rows)
            {
                if (row.Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("Verifique que los Insumos esten Correctamente Añadidos");
                    return;
                }
                if (row.Cells[2].Value.ToString() == "0")
                {
                    MessageBox.Show("la cantidad no puede ser 0");
                    return;
                }
            }
            foreach (DataGridViewRow row in dgvCargo.Rows)
            {
                lista.IDInsumo = Convert.ToInt32(row.Cells[0].Value);
                lista.Cantidad = Convert.ToDecimal(row.Cells[2].Value);
                lista.GuardarLista();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.DataSource != null)
            {
                Cargardatos(Convert.ToInt32(comboBox1.SelectedValue));
            }
        }
    }
}
