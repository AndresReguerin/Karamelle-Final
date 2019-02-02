namespace Karamelle
{
    partial class VerPedido
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
            this.button2 = new System.Windows.Forms.Button();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.pnEncabezado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPastelero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPastelero = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lvlNoEstudio = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtDecorador = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCarnetIdentidad = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtIDTransaccion = new System.Windows.Forms.TextBox();
            this.txtIDDecorador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtRecibido = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IDPastel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pastel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.pnEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPastel,
            this.Pastel,
            this.Tamaño,
            this.Cantidad,
            this.Decoracion});
            this.dgvCargo.Location = new System.Drawing.Point(11, 146);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.RowHeadersVisible = false;
            this.dgvCargo.Size = new System.Drawing.Size(633, 237);
            this.dgvCargo.TabIndex = 28;
            // 
            // pnEncabezado
            // 
            this.pnEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.pnEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEncabezado.Controls.Add(this.label3);
            this.pnEncabezado.Controls.Add(this.dtRecibido);
            this.pnEncabezado.Controls.Add(this.label5);
            this.pnEncabezado.Controls.Add(this.label1);
            this.pnEncabezado.Controls.Add(this.txtPastelero);
            this.pnEncabezado.Controls.Add(this.label2);
            this.pnEncabezado.Controls.Add(this.txtIDPastelero);
            this.pnEncabezado.Controls.Add(this.label18);
            this.pnEncabezado.Controls.Add(this.txtIdPaciente);
            this.pnEncabezado.Controls.Add(this.lblIdPaciente);
            this.pnEncabezado.Controls.Add(this.label17);
            this.pnEncabezado.Controls.Add(this.lvlNoEstudio);
            this.pnEncabezado.Controls.Add(this.txtPedido);
            this.pnEncabezado.Controls.Add(this.label14);
            this.pnEncabezado.Controls.Add(this.label11);
            this.pnEncabezado.Controls.Add(this.label7);
            this.pnEncabezado.Controls.Add(this.label6);
            this.pnEncabezado.Controls.Add(this.label4);
            this.pnEncabezado.Controls.Add(this.lblEstado);
            this.pnEncabezado.Controls.Add(this.txtEstado);
            this.pnEncabezado.Controls.Add(this.txtDecorador);
            this.pnEncabezado.Controls.Add(this.dtFecha);
            this.pnEncabezado.Controls.Add(this.lblFecha);
            this.pnEncabezado.Controls.Add(this.lblCarnetIdentidad);
            this.pnEncabezado.Controls.Add(this.txtNit);
            this.pnEncabezado.Controls.Add(this.txtNombre);
            this.pnEncabezado.Controls.Add(this.lblNombreCompleto);
            this.pnEncabezado.Controls.Add(this.lblMedico);
            this.pnEncabezado.Controls.Add(this.txtIDTransaccion);
            this.pnEncabezado.Controls.Add(this.txtIDDecorador);
            this.pnEncabezado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnEncabezado.Location = new System.Drawing.Point(11, 8);
            this.pnEncabezado.Name = "pnEncabezado";
            this.pnEncabezado.Size = new System.Drawing.Size(633, 132);
            this.pnEncabezado.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 2);
            this.label1.TabIndex = 47;
            this.label1.Text = "label1";
            // 
            // txtPastelero
            // 
            this.txtPastelero.Location = new System.Drawing.Point(138, 102);
            this.txtPastelero.Name = "txtPastelero";
            this.txtPastelero.ReadOnly = true;
            this.txtPastelero.Size = new System.Drawing.Size(259, 20);
            this.txtPastelero.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pastelero";
            // 
            // txtIDPastelero
            // 
            this.txtIDPastelero.Location = new System.Drawing.Point(138, 102);
            this.txtIDPastelero.Name = "txtIDPastelero";
            this.txtIDPastelero.ReadOnly = true;
            this.txtIDPastelero.Size = new System.Drawing.Size(100, 20);
            this.txtIDPastelero.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 2);
            this.label18.TabIndex = 40;
            this.label18.Text = "label18";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Location = new System.Drawing.Point(138, 10);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(35, 20);
            this.txtIdPaciente.TabIndex = 39;
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPaciente.Location = new System.Drawing.Point(12, 13);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(125, 15);
            this.lblIdPaciente.TabIndex = 38;
            this.lblIdPaciente.Text = "ID Cliente";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(405, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 2);
            this.label17.TabIndex = 36;
            this.label17.Text = "label17";
            // 
            // lvlNoEstudio
            // 
            this.lvlNoEstudio.AutoSize = true;
            this.lvlNoEstudio.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNoEstudio.Location = new System.Drawing.Point(404, 13);
            this.lvlNoEstudio.Name = "lvlNoEstudio";
            this.lvlNoEstudio.Size = new System.Drawing.Size(55, 13);
            this.lvlNoEstudio.TabIndex = 35;
            this.lvlNoEstudio.Text = "Pedido #";
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(520, 8);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(104, 20);
            this.txtPedido.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(402, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 2);
            this.label14.TabIndex = 33;
            this.label14.Text = "label14";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 2);
            this.label11.TabIndex = 32;
            this.label11.Text = "label11";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 2);
            this.label7.TabIndex = 30;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 2);
            this.label6.TabIndex = 29;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 2);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(404, 34);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 13);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(520, 30);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(104, 20);
            this.txtEstado.TabIndex = 24;
            // 
            // txtDecorador
            // 
            this.txtDecorador.Location = new System.Drawing.Point(138, 76);
            this.txtDecorador.Name = "txtDecorador";
            this.txtDecorador.ReadOnly = true;
            this.txtDecorador.Size = new System.Drawing.Size(259, 20);
            this.txtDecorador.TabIndex = 17;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(520, 52);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.ShowUpDown = true;
            this.dtFecha.Size = new System.Drawing.Size(103, 20);
            this.dtFecha.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(404, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha Entrega";
            // 
            // lblCarnetIdentidad
            // 
            this.lblCarnetIdentidad.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetIdentidad.Location = new System.Drawing.Point(9, 59);
            this.lblCarnetIdentidad.Name = "lblCarnetIdentidad";
            this.lblCarnetIdentidad.Size = new System.Drawing.Size(128, 15);
            this.lblCarnetIdentidad.TabIndex = 16;
            this.lblCarnetIdentidad.Text = "Nit";
            // 
            // txtNit
            // 
            this.txtNit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNit.Enabled = false;
            this.txtNit.Location = new System.Drawing.Point(138, 55);
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            this.txtNit.Size = new System.Drawing.Size(121, 20);
            this.txtNit.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(9, 37);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(114, 15);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblMedico
            // 
            this.lblMedico.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(9, 79);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(128, 15);
            this.lblMedico.TabIndex = 12;
            this.lblMedico.Text = "Decorador";
            // 
            // txtIDTransaccion
            // 
            this.txtIDTransaccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDTransaccion.Location = new System.Drawing.Point(520, 8);
            this.txtIDTransaccion.Name = "txtIDTransaccion";
            this.txtIDTransaccion.Size = new System.Drawing.Size(104, 20);
            this.txtIDTransaccion.TabIndex = 43;
            // 
            // txtIDDecorador
            // 
            this.txtIDDecorador.Location = new System.Drawing.Point(138, 76);
            this.txtIDDecorador.Name = "txtIDDecorador";
            this.txtIDDecorador.ReadOnly = true;
            this.txtIDDecorador.Size = new System.Drawing.Size(100, 20);
            this.txtIDDecorador.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 2);
            this.label3.TabIndex = 51;
            this.label3.Text = "label3";
            // 
            // dtRecibido
            // 
            this.dtRecibido.Enabled = false;
            this.dtRecibido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRecibido.Location = new System.Drawing.Point(520, 76);
            this.dtRecibido.Name = "dtRecibido";
            this.dtRecibido.ShowUpDown = true;
            this.dtRecibido.Size = new System.Drawing.Size(103, 20);
            this.dtRecibido.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha Recibido";
            // 
            // IDPastel
            // 
            this.IDPastel.HeaderText = "IDPastel";
            this.IDPastel.Name = "IDPastel";
            this.IDPastel.ReadOnly = true;
            this.IDPastel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pastel
            // 
            this.Pastel.HeaderText = "Pastel";
            this.Pastel.Name = "Pastel";
            this.Pastel.ReadOnly = true;
            this.Pastel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Pastel.Width = 150;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            this.Tamaño.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 75;
            // 
            // Decoracion
            // 
            this.Decoracion.HeaderText = "Decoracion";
            this.Decoracion.Name = "Decoracion";
            this.Decoracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Decoracion.Width = 205;
            // 
            // VerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvCargo);
            this.Controls.Add(this.pnEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerPedido";
            this.Load += new System.EventHandler(this.VerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.pnEncabezado.ResumeLayout(false);
            this.pnEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.Panel pnEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPastelero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPastelero;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lvlNoEstudio;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtDecorador;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCarnetIdentidad;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtIDTransaccion;
        private System.Windows.Forms.TextBox txtIDDecorador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtRecibido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPastel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pastel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decoracion;
    }
}