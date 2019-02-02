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
    public partial class ListadoPastelero : Form
    {
        public ListadoPastelero()
        {
            InitializeComponent();
        }
        Negocio.Detalle det = new Negocio.Detalle();
        Negocio.ListaIngrediente past = new Negocio.ListaIngrediente();
        int idpastel;
        int idped;
        private void ListadoPastelero_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }
        private void Cargar()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in det.CargarDetPastelero(Program.IDUsuario).Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), fila[4].ToString(), fila[5].ToString());
            }
        }
        private void CargarIngredientes()
        {
            dgvIngredientes.Rows.Clear();
            foreach (DataRow fila in past.CargarLista(idpastel).Rows)
            {
                dgvIngredientes.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()));
            }
        }
        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvIngredientes.Rows.Clear();
                if (dgvCargo.CurrentRow != null)
                {
                    idped = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    idpastel = Convert.ToInt32(dgvCargo.CurrentRow.Cells[1].Value.ToString());
                    CargarIngredientes();
                    
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }

        private void completadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idped != 0)
                {
                    det.actualizarEstado(2, idped, idpastel);
                    Cargar();
                }
                else
                {
                    MessageBox.Show("");
                }

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
