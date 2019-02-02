namespace Karamelle.Reportes
{
    partial class Reporte3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDeco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPastelero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pastelero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.AllowUserToDeleteRows = false;
            this.dgvCargo.AllowUserToResizeColumns = false;
            this.dgvCargo.AllowUserToResizeRows = false;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDCliente,
            this.Cliente,
            this.Nit,
            this.IDDeco,
            this.Decorador,
            this.IDPastelero,
            this.Pastelero,
            this.FechaP,
            this.FechaE,
            this.Estado});
            this.dgvCargo.Location = new System.Drawing.Point(12, 55);
            this.dgvCargo.MultiSelect = false;
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.RowHeadersVisible = false;
            this.dgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargo.Size = new System.Drawing.Size(915, 295);
            this.dgvCargo.TabIndex = 41;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "IDCliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 150;
            // 
            // Nit
            // 
            this.Nit.HeaderText = "Nit";
            this.Nit.Name = "Nit";
            this.Nit.ReadOnly = true;
            // 
            // IDDeco
            // 
            this.IDDeco.HeaderText = "IDDecorador";
            this.IDDeco.Name = "IDDeco";
            this.IDDeco.ReadOnly = true;
            this.IDDeco.Visible = false;
            // 
            // Decorador
            // 
            this.Decorador.HeaderText = "Decorador";
            this.Decorador.Name = "Decorador";
            this.Decorador.ReadOnly = true;
            this.Decorador.Width = 150;
            // 
            // IDPastelero
            // 
            this.IDPastelero.HeaderText = "IDPastelero";
            this.IDPastelero.Name = "IDPastelero";
            this.IDPastelero.ReadOnly = true;
            this.IDPastelero.Visible = false;
            // 
            // Pastelero
            // 
            this.Pastelero.HeaderText = "Pastelero";
            this.Pastelero.Name = "Pastelero";
            this.Pastelero.ReadOnly = true;
            this.Pastelero.Width = 150;
            // 
            // FechaP
            // 
            this.FechaP.HeaderText = "Pedido";
            this.FechaP.Name = "FechaP";
            this.FechaP.ReadOnly = true;
            // 
            // FechaE
            // 
            this.FechaE.HeaderText = "Entrega";
            this.FechaE.Name = "FechaE";
            this.FechaE.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Todos los Pedidos";
            // 
            // Reporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reporte3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte 3";
            this.Load += new System.EventHandler(this.Reporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDeco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPastelero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pastelero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
    }
}