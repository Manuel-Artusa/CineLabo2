namespace Cines.Presentacion
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            lblFacturaNro = new Label();
            lblEmpleado = new Label();
            lblCliente = new Label();
            lblCantidad = new Label();
            lblDescuento = new Label();
            lblCine = new Label();
            lblPelicula = new Label();
            cboCine = new ComboBox();
            cboPelicula = new ComboBox();
            txtEmpleado = new TextBox();
            txtCliente = new TextBox();
            txtDescuento = new TextBox();
            nudCantidad = new NumericUpDown();
            btnS1 = new Button();
            btnS15 = new Button();
            btnS14 = new Button();
            btnS13 = new Button();
            btnS12 = new Button();
            btnS11 = new Button();
            btnS10 = new Button();
            btnS9 = new Button();
            btnS8 = new Button();
            btnS7 = new Button();
            btnS6 = new Button();
            btnS5 = new Button();
            btnS4 = new Button();
            btnS3 = new Button();
            btnS2 = new Button();
            btnS18 = new Button();
            btnS17 = new Button();
            btnS16 = new Button();
            gpPantalla = new GroupBox();
            dataGridView1 = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColCine = new DataGridViewTextBoxColumn();
            ColEmpleado = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColDescuento = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            lblSubTotal = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            gbAsientos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbAsientos.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(255, 255, 128);
            lblFecha.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(20, 69);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblFacturaNro
            // 
            lblFacturaNro.AutoSize = true;
            lblFacturaNro.BackColor = Color.FromArgb(255, 255, 128);
            lblFacturaNro.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaNro.Location = new Point(20, 34);
            lblFacturaNro.Name = "lblFacturaNro";
            lblFacturaNro.Size = new Size(126, 17);
            lblFacturaNro.TabIndex = 2;
            lblFacturaNro.Text = "Factura Numero";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(255, 255, 128);
            lblEmpleado.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(20, 132);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(77, 17);
            lblEmpleado.TabIndex = 3;
            lblEmpleado.Text = "Empleado";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(255, 255, 128);
            lblCliente.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(20, 165);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 17);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(255, 255, 128);
            lblCantidad.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(20, 198);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(140, 17);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad Asientos";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.FromArgb(255, 255, 128);
            lblDescuento.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(20, 228);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(85, 17);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "Descuento";
            // 
            // lblCine
            // 
            lblCine.AutoSize = true;
            lblCine.BackColor = Color.FromArgb(255, 255, 128);
            lblCine.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCine.Location = new Point(20, 100);
            lblCine.Name = "lblCine";
            lblCine.Size = new Size(37, 17);
            lblCine.TabIndex = 7;
            lblCine.Text = "Cine";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.BackColor = Color.FromArgb(255, 255, 128);
            lblPelicula.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPelicula.Location = new Point(20, 259);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(69, 17);
            lblPelicula.TabIndex = 8;
            lblPelicula.Text = "Pelicula";
            // 
            // cboCine
            // 
            cboCine.FormattingEnabled = true;
            cboCine.Location = new Point(74, 94);
            cboCine.Name = "cboCine";
            cboCine.Size = new Size(235, 23);
            cboCine.TabIndex = 9;
            // 
            // cboPelicula
            // 
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(104, 253);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(205, 23);
            cboPelicula.TabIndex = 10;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(116, 126);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(193, 23);
            txtEmpleado.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(95, 159);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(214, 23);
            txtCliente.TabIndex = 12;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(116, 224);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(193, 23);
            txtDescuento.TabIndex = 13;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(166, 192);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(143, 23);
            nudCantidad.TabIndex = 14;
            // 
            // btnS1
            // 
            btnS1.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS1.BackgroundImageLayout = ImageLayout.Zoom;
            btnS1.Location = new Point(46, 14);
            btnS1.Name = "btnS1";
            btnS1.Size = new Size(23, 23);
            btnS1.TabIndex = 15;
            btnS1.UseVisualStyleBackColor = true;
            
            // 
            // btnS15
            // 
            btnS15.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS15.BackgroundImageLayout = ImageLayout.Zoom;
            btnS15.Location = new Point(104, 94);
            btnS15.Name = "btnS15";
            btnS15.Size = new Size(23, 23);
            btnS15.TabIndex = 16;
            btnS15.UseVisualStyleBackColor = true;
            // 
            // btnS14
            // 
            btnS14.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS14.BackgroundImageLayout = ImageLayout.Zoom;
            btnS14.Location = new Point(75, 94);
            btnS14.Name = "btnS14";
            btnS14.Size = new Size(23, 23);
            btnS14.TabIndex = 17;
            btnS14.UseVisualStyleBackColor = true;
            // 
            // btnS13
            // 
            btnS13.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS13.BackgroundImageLayout = ImageLayout.Zoom;
            btnS13.Location = new Point(46, 94);
            btnS13.Name = "btnS13";
            btnS13.Size = new Size(23, 23);
            btnS13.TabIndex = 18;
            btnS13.UseVisualStyleBackColor = true;
            // 
            // btnS12
            // 
            btnS12.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS12.BackgroundImageLayout = ImageLayout.Zoom;
            btnS12.Location = new Point(220, 56);
            btnS12.Name = "btnS12";
            btnS12.Size = new Size(23, 23);
            btnS12.TabIndex = 19;
            btnS12.UseVisualStyleBackColor = true;
            // 
            // btnS11
            // 
            btnS11.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS11.BackgroundImageLayout = ImageLayout.Zoom;
            btnS11.Location = new Point(191, 56);
            btnS11.Name = "btnS11";
            btnS11.Size = new Size(23, 23);
            btnS11.TabIndex = 20;
            btnS11.UseVisualStyleBackColor = true;
            // 
            // btnS10
            // 
            btnS10.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS10.BackgroundImageLayout = ImageLayout.Zoom;
            btnS10.Location = new Point(162, 57);
            btnS10.Name = "btnS10";
            btnS10.Size = new Size(23, 23);
            btnS10.TabIndex = 21;
            btnS10.UseVisualStyleBackColor = true;
            // 
            // btnS9
            // 
            btnS9.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS9.BackgroundImageLayout = ImageLayout.Zoom;
            btnS9.Location = new Point(104, 56);
            btnS9.Name = "btnS9";
            btnS9.Size = new Size(23, 23);
            btnS9.TabIndex = 22;
            btnS9.UseVisualStyleBackColor = true;
            // 
            // btnS8
            // 
            btnS8.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS8.BackgroundImageLayout = ImageLayout.Zoom;
            btnS8.Location = new Point(75, 56);
            btnS8.Name = "btnS8";
            btnS8.Size = new Size(23, 23);
            btnS8.TabIndex = 23;
            btnS8.UseVisualStyleBackColor = true;
            // 
            // btnS7
            // 
            btnS7.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS7.BackgroundImageLayout = ImageLayout.Zoom;
            btnS7.Location = new Point(46, 56);
            btnS7.Name = "btnS7";
            btnS7.Size = new Size(23, 23);
            btnS7.TabIndex = 24;
            btnS7.UseVisualStyleBackColor = true;
            // 
            // btnS6
            // 
            btnS6.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS6.BackgroundImageLayout = ImageLayout.Zoom;
            btnS6.Location = new Point(220, 14);
            btnS6.Name = "btnS6";
            btnS6.Size = new Size(23, 23);
            btnS6.TabIndex = 25;
            btnS6.UseVisualStyleBackColor = true;
            // 
            // btnS5
            // 
            btnS5.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS5.BackgroundImageLayout = ImageLayout.Zoom;
            btnS5.Location = new Point(191, 14);
            btnS5.Name = "btnS5";
            btnS5.Size = new Size(23, 23);
            btnS5.TabIndex = 26;
            btnS5.UseVisualStyleBackColor = true;
            // 
            // btnS4
            // 
            btnS4.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS4.BackgroundImageLayout = ImageLayout.Zoom;
            btnS4.Location = new Point(162, 14);
            btnS4.Name = "btnS4";
            btnS4.Size = new Size(23, 23);
            btnS4.TabIndex = 27;
            btnS4.UseVisualStyleBackColor = true;
            // 
            // btnS3
            // 
            btnS3.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS3.BackgroundImageLayout = ImageLayout.Zoom;
            btnS3.Location = new Point(104, 14);
            btnS3.Name = "btnS3";
            btnS3.Size = new Size(23, 23);
            btnS3.TabIndex = 28;
            btnS3.UseVisualStyleBackColor = true;
            // 
            // btnS2
            // 
            btnS2.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS2.BackgroundImageLayout = ImageLayout.Zoom;
            btnS2.Location = new Point(75, 14);
            btnS2.Name = "btnS2";
            btnS2.Size = new Size(23, 23);
            btnS2.TabIndex = 29;
            btnS2.UseVisualStyleBackColor = true;
            // 
            // btnS18
            // 
            btnS18.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS18.BackgroundImageLayout = ImageLayout.Zoom;
            btnS18.Location = new Point(220, 94);
            btnS18.Name = "btnS18";
            btnS18.Size = new Size(23, 23);
            btnS18.TabIndex = 31;
            btnS18.UseVisualStyleBackColor = true;
            // 
            // btnS17
            // 
            btnS17.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS17.BackgroundImageLayout = ImageLayout.Zoom;
            btnS17.Location = new Point(191, 94);
            btnS17.Name = "btnS17";
            btnS17.Size = new Size(23, 23);
            btnS17.TabIndex = 32;
            btnS17.UseVisualStyleBackColor = true;
            // 
            // btnS16
            // 
            btnS16.BackgroundImage = CinesFront.Properties.Resources.silla;
            btnS16.BackgroundImageLayout = ImageLayout.Zoom;
            btnS16.Location = new Point(162, 94);
            btnS16.Name = "btnS16";
            btnS16.Size = new Size(23, 23);
            btnS16.TabIndex = 33;
            btnS16.UseVisualStyleBackColor = true;
            // 
            // gpPantalla
            // 
            gpPantalla.BackColor = Color.Yellow;
            gpPantalla.BackgroundImage = CinesFront.Properties.Resources.pantalla_de_cine;
            gpPantalla.BackgroundImageLayout = ImageLayout.Zoom;
            gpPantalla.Location = new Point(556, 63);
            gpPantalla.Name = "gpPantalla";
            gpPantalla.Size = new Size(202, 110);
            gpPantalla.TabIndex = 34;
            gpPantalla.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColCantidad, ColCine, ColEmpleado, ColCliente, ColDescuento, ColQuitar });
            dataGridView1.Location = new Point(20, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(828, 183);
            dataGridView1.TabIndex = 35;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColCine
            // 
            ColCine.HeaderText = "Cine";
            ColCine.Name = "ColCine";
            ColCine.ReadOnly = true;
            // 
            // ColEmpleado
            // 
            ColEmpleado.HeaderText = "Empleado";
            ColEmpleado.Name = "ColEmpleado";
            ColEmpleado.ReadOnly = true;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColDescuento
            // 
            ColDescuento.HeaderText = "Descuento";
            ColDescuento.Name = "ColDescuento";
            ColDescuento.ReadOnly = true;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "QUITAR";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.FromArgb(255, 255, 128);
            lblSubTotal.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(677, 501);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(77, 17);
            lblSubTotal.TabIndex = 36;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(255, 255, 128);
            lblTotal.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(677, 531);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 17);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(763, 495);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(85, 23);
            txtSubTotal.TabIndex = 38;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(735, 525);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(113, 23);
            txtTotal.TabIndex = 39;
            // 
            // gbAsientos
            // 
            gbAsientos.Controls.Add(btnS2);
            gbAsientos.Controls.Add(btnS1);
            gbAsientos.Controls.Add(btnS15);
            gbAsientos.Controls.Add(btnS14);
            gbAsientos.Controls.Add(btnS13);
            gbAsientos.Controls.Add(btnS12);
            gbAsientos.Controls.Add(btnS11);
            gbAsientos.Controls.Add(btnS16);
            gbAsientos.Controls.Add(btnS10);
            gbAsientos.Controls.Add(btnS17);
            gbAsientos.Controls.Add(btnS9);
            gbAsientos.Controls.Add(btnS18);
            gbAsientos.Controls.Add(btnS8);
            gbAsientos.Controls.Add(btnS7);
            gbAsientos.Controls.Add(btnS3);
            gbAsientos.Controls.Add(btnS6);
            gbAsientos.Controls.Add(btnS4);
            gbAsientos.Controls.Add(btnS5);
            gbAsientos.Location = new Point(510, 176);
            gbAsientos.Name = "gbAsientos";
            gbAsientos.Size = new Size(289, 123);
            gbAsientos.TabIndex = 40;
            gbAsientos.TabStop = false;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 557);
            Controls.Add(gbAsientos);
            Controls.Add(txtTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblSubTotal);
            Controls.Add(dataGridView1);
            Controls.Add(gpPantalla);
            Controls.Add(nudCantidad);
            Controls.Add(txtDescuento);
            Controls.Add(txtCliente);
            Controls.Add(txtEmpleado);
            Controls.Add(cboPelicula);
            Controls.Add(cboCine);
            Controls.Add(lblPelicula);
            Controls.Add(lblCine);
            Controls.Add(lblDescuento);
            Controls.Add(lblCantidad);
            Controls.Add(lblCliente);
            Controls.Add(lblEmpleado);
            Controls.Add(lblFacturaNro);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePicker1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmVentas";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
           
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbAsientos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private Label lblFacturaNro;
        private Label lblEmpleado;
        private Label lblCliente;
        private Label lblCantidad;
        private Label lblDescuento;
        private Label lblCine;
        private Label lblPelicula;
        private ComboBox cboCine;
        private ComboBox cboPelicula;
        private TextBox txtEmpleado;
        private TextBox txtCliente;
        private TextBox txtDescuento;
        private NumericUpDown nudCantidad;
        private Button btnS1;
        private Button btnS15;
        private Button btnS14;
        private Button btnS13;
        private Button btnS12;
        private Button btnS11;
        private Button btnS10;
        private Button btnS9;
        private Button btnS8;
        private Button btnS7;
        private Button btnS6;
        private Button btnS5;
        private Button btnS4;
        private Button btnS3;
        private Button btnS2;
        private Button btnS18;
        private Button btnS17;
        private Button btnS16;
        private GroupBox gpPantalla;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColCine;
        private DataGridViewTextBoxColumn ColEmpleado;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColDescuento;
        private DataGridViewButtonColumn ColQuitar;
        private Label lblSubTotal;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
        private GroupBox gbAsientos;
    }
}