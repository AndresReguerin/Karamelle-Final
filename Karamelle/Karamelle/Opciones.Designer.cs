namespace Karamelle
{
    partial class Opciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAutorizaciones = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAutorizacion = new System.Windows.Forms.DataGridView();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lbxUsuarios = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutorizaciones
            // 
            this.lblAutorizaciones.AutoSize = true;
            this.lblAutorizaciones.Location = new System.Drawing.Point(240, 11);
            this.lblAutorizaciones.Name = "lblAutorizaciones";
            this.lblAutorizaciones.Size = new System.Drawing.Size(90, 13);
            this.lblAutorizaciones.TabIndex = 11;
            this.lblAutorizaciones.Text = "Autorizaciones";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(96, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(15, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAutorizacion
            // 
            this.dgvAutorizacion.AllowUserToAddRows = false;
            this.dgvAutorizacion.AllowUserToDeleteRows = false;
            this.dgvAutorizacion.AllowUserToResizeColumns = false;
            this.dgvAutorizacion.AllowUserToResizeRows = false;
            this.dgvAutorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUsuario,
            this.NoDocumento,
            this.Descripcion});
            this.dgvAutorizacion.Location = new System.Drawing.Point(242, 26);
            this.dgvAutorizacion.Name = "dgvAutorizacion";
            this.dgvAutorizacion.RowHeadersVisible = false;
            this.dgvAutorizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutorizacion.Size = new System.Drawing.Size(676, 400);
            this.dgvAutorizacion.TabIndex = 8;
            // 
            // IDUsuario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IDUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.IDUsuario.HeaderText = "IDUsuario";
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            this.IDUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDUsuario.Visible = false;
            // 
            // NoDocumento
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoDocumento.DefaultCellStyle = dataGridViewCellStyle2;
            this.NoDocumento.HeaderText = "NoDocumento";
            this.NoDocumento.Name = "NoDocumento";
            this.NoDocumento.ReadOnly = true;
            this.NoDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descipcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 200;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(12, 11);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(55, 13);
            this.lblUsuarios.TabIndex = 7;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lbxUsuarios
            // 
            this.lbxUsuarios.FormattingEnabled = true;
            this.lbxUsuarios.Location = new System.Drawing.Point(15, 26);
            this.lbxUsuarios.Name = "lbxUsuarios";
            this.lbxUsuarios.Size = new System.Drawing.Size(221, 394);
            this.lbxUsuarios.TabIndex = 6;
            this.lbxUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbxUsuarios_SelectedIndexChanged);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 475);
            this.Controls.Add(this.lblAutorizaciones);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAutorizacion);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lbxUsuarios);
            this.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutorizaciones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.ListBox lbxUsuarios;
    }
}