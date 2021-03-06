﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karamelle
{
    public partial class ActualizarPedido : Form
    {
        public ActualizarPedido()
        {
            InitializeComponent();
        }
        public int id;
        Negocio.Pedidos ped = new Negocio.Pedidos();
        Negocio.Detalle det = new Negocio.Detalle();
        private void ActualizarPedido_Load(object sender, EventArgs e)
        {
            cargardatos(id);
        }
        private void cargardatos(int id)
        {
            dgvCargo.Rows.Clear();
            foreach (DataRow fila in ped.CargarPedidoid(id).Rows)
            {
                txtPedido.Text = fila[0].ToString();
                txtIdPaciente.Text = fila[1].ToString();
                txtNombre.Text = fila[2].ToString();
                txtNit.Text = fila[3].ToString();
                txtIDDecorador.Text = fila[4].ToString();
                txtDecorador.Text = fila[5].ToString();
                txtIDPastelero.Text = fila[6].ToString();
                txtPastelero.Text = fila[7].ToString();
                dtFecha.Value = Convert.ToDateTime(fila[9].ToString());
                dtRecibido.Value = Convert.ToDateTime(fila[8].ToString());
                txtEstado.Text = fila[10].ToString();
            }
            foreach (DataRow row in det.CargarDetallePedido(id).Rows)
            {
                dgvCargo.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            }

        }

        private void realizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEstado.Text == "Pendiente")
                {
                    ped.ActualizarEstado(2, id);
                    MessageBox.Show("Realizado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Imposible Cambiar de Estado");
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEstado.Text == "Pendiente")
                {
                    ped.ActualizarEstado(3, id);
                    MessageBox.Show("Anulado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Imposible Cambiar de Estado");
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
