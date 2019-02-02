using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karamelle.Reportes
{
    public partial class Reporte3 : Form
    {
        public Reporte3()
        {
            InitializeComponent();
        }
        Negocio.Pedidos ped = new Negocio.Pedidos();
        private void Reporte3_Load(object sender, EventArgs e)
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
    }
}
