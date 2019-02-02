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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Negocio.Opciones aut = new Negocio.Opciones();
        private void Inicio_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
                this.Dispose();
                return;
            }
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal f = new Personal();
            if (aut.existe(Program.IDUsuario, 2))
            {
                
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {

                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
           
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones f = new Opciones();
            if (aut.existe(Program.IDUsuario, 1))
            {
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
           
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente f = new Cliente();
            if (aut.existe(Program.IDUsuario, 3))
            {
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
               

            }
            
        }

        private void pastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pastel f = new Pastel();
            if (aut.existe(Program.IDUsuario, 4))
            {
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (aut.existe(Program.IDUsuario, 5))
            {
                Insumo f = new Insumo();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    Insumo f = new Insumo();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (aut.existe(Program.IDUsuario, 6))
            {
                Pastel f = new Pastel();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    Pastel f = new Pastel();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
               

            }
        }

        private void listaIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aut.existe(Program.IDUsuario, 7))
            {
                ListaIngredientes f = new ListaIngredientes();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    ListaIngredientes f = new ListaIngredientes();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tamañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aut.existe(Program.IDUsuario, 6))
            {
                Tamaño f = new Tamaño();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    Tamaño f = new Tamaño();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    
                    
                        MessageBox.Show("Acceso No Autorizado");
                    
                }
               

            }

        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aut.existe(Program.IDUsuario, 8))
            {
                Pedidos f = new Pedidos();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    Pedidos f = new Pedidos();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
            
        }

        private void listaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (aut.existe(Program.IDUsuario, 8))
            {
                ListaPedidos f = new ListaPedidos();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (Program.IDUsuario == 0)
                {
                    ListaPedidos f = new ListaPedidos();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acceso No Autorizado");
                }
                

            }
           
        }

        private void listadoPasteleroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ListadoPastelero p = new ListadoPastelero();
            p.Show();
        }

        private void listadoDecoradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDecorador p = new ListadoDecorador();
            p.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.Reportes f = new Reportes.Reportes();
            f.Show();
        }
    }
}
