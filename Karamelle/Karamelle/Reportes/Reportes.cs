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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frReporte1 f = new frReporte1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte2 f = new Reporte2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte3 f = new Reporte3();
            f.Show();
        }
    }
}
