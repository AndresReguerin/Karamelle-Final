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
    public partial class ListadoDecorador : Form
    {
        public ListadoDecorador()
        {
            InitializeComponent();
        }
        Negocio.Detalle det = new Negocio.Detalle();
        Negocio.ListaIngrediente past = new Negocio.ListaIngrediente();
        int idpastel;
        int idped;

        private void completadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idped != 0)
                {
                    det.actualizarEstado(3, idped, idpastel);
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

        private void ListadoDecorador_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in det.CargarDetDecorador(Program.IDUsuario).Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), fila[4].ToString(), fila[5].ToString());
            }
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dgvCargo.CurrentRow != null)
                {
                    idped = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                    idpastel = Convert.ToInt32(dgvCargo.CurrentRow.Cells[1].Value.ToString());
                   

                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }
    }
}
