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
    public partial class frReporte1 : Form
    {
        public frReporte1()
        {
            InitializeComponent();
        }
        Negocio.Reportes rep = new Negocio.Reportes();
        private void frReporte1_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
        private void cargardatos()
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in rep.CargarReporte1().Rows)
            {
                dgvCargo.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), (fila[3].ToString()), (fila[4].ToString()));
            }
        }
    }
}
