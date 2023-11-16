namespace CineApp.Forms
{
    partial class frmAdministrador
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
            pbFondoMenu = new PictureBox();
            iconoMenu = new PictureBox();
            lblMenu = new Label();
            iconoSoporte = new PictureBox();
            iconoTransaccion = new PictureBox();
            iconoReporte = new PictureBox();
            iconoNosotros = new PictureBox();
            lblSoporte = new Label();
            lblTransaccion = new Label();
            lblReporte = new Label();
            lblNosotros = new Label();
            btnSalir = new Button();
            iconoSalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFondoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoSoporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoTransaccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoNosotros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoSalir).BeginInit();
            SuspendLayout();
            // 
            // pbFondoMenu
            // 
            pbFondoMenu.BackColor = Color.IndianRed;
            pbFondoMenu.Location = new Point(-1, 0);
            pbFondoMenu.Name = "pbFondoMenu";
            pbFondoMenu.Size = new Size(400, 1060);
            pbFondoMenu.TabIndex = 0;
            pbFondoMenu.TabStop = false;
            // 
            // iconoMenu
            // 
            iconoMenu.BackColor = Color.IndianRed;
            iconoMenu.Image = CIneLabo.Properties.Resources.boton_menu;
            iconoMenu.Location = new Point(36, 74);
            iconoMenu.Name = "iconoMenu";
            iconoMenu.Size = new Size(57, 54);
            iconoMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoMenu.TabIndex = 1;
            iconoMenu.TabStop = false;
            iconoMenu.Click += iconoMenu_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.IndianRed;
            lblMenu.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(180, 85);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(100, 32);
            lblMenu.TabIndex = 73;
            lblMenu.Text = "MENU";
            // 
            // iconoSoporte
            // 
            iconoSoporte.BackColor = Color.IndianRed;
            iconoSoporte.Image = CIneLabo.Properties.Resources.boton_soporte;
            iconoSoporte.Location = new Point(36, 248);
            iconoSoporte.Name = "iconoSoporte";
            iconoSoporte.Size = new Size(57, 54);
            iconoSoporte.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoSoporte.TabIndex = 74;
            iconoSoporte.TabStop = false;
            // 
            // iconoTransaccion
            // 
            iconoTransaccion.BackColor = Color.IndianRed;
            iconoTransaccion.Image = CIneLabo.Properties.Resources.boton_transaccion;
            iconoTransaccion.Location = new Point(36, 405);
            iconoTransaccion.Name = "iconoTransaccion";
            iconoTransaccion.Size = new Size(57, 54);
            iconoTransaccion.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoTransaccion.TabIndex = 75;
            iconoTransaccion.TabStop = false;
            // 
            // iconoReporte
            // 
            iconoReporte.BackColor = Color.IndianRed;
            iconoReporte.Image = CIneLabo.Properties.Resources.boton_reporte;
            iconoReporte.Location = new Point(36, 582);
            iconoReporte.Name = "iconoReporte";
            iconoReporte.Size = new Size(57, 54);
            iconoReporte.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoReporte.TabIndex = 76;
            iconoReporte.TabStop = false;
            iconoReporte.Click += iconoReporte_Click;
            // 
            // iconoNosotros
            // 
            iconoNosotros.BackColor = Color.IndianRed;
            iconoNosotros.Image = CIneLabo.Properties.Resources.boton_nosotros;
            iconoNosotros.Location = new Point(36, 752);
            iconoNosotros.Name = "iconoNosotros";
            iconoNosotros.Size = new Size(57, 54);
            iconoNosotros.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoNosotros.TabIndex = 77;
            iconoNosotros.TabStop = false;
            // 
            // lblSoporte
            // 
            lblSoporte.AutoSize = true;
            lblSoporte.BackColor = Color.IndianRed;
            lblSoporte.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoporte.ForeColor = Color.Black;
            lblSoporte.Location = new Point(147, 260);
            lblSoporte.Name = "lblSoporte";
            lblSoporte.Size = new Size(159, 32);
            lblSoporte.TabIndex = 78;
            lblSoporte.Text = "SOPORTE";
            // 
            // lblTransaccion
            // 
            lblTransaccion.AutoSize = true;
            lblTransaccion.BackColor = Color.IndianRed;
            lblTransaccion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransaccion.ForeColor = Color.Black;
            lblTransaccion.Location = new Point(119, 418);
            lblTransaccion.Name = "lblTransaccion";
            lblTransaccion.Size = new Size(268, 32);
            lblTransaccion.TabIndex = 79;
            lblTransaccion.Text = "TRANSACCIONES";
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.BackColor = Color.IndianRed;
            lblReporte.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblReporte.ForeColor = Color.Black;
            lblReporte.Location = new Point(149, 591);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(177, 32);
            lblReporte.TabIndex = 80;
            lblReporte.Text = "REPORTES";
            lblReporte.Click += lblReporte_Click;
            // 
            // lblNosotros
            // 
            lblNosotros.AutoSize = true;
            lblNosotros.BackColor = Color.IndianRed;
            lblNosotros.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNosotros.ForeColor = Color.Black;
            lblNosotros.Location = new Point(147, 764);
            lblNosotros.Name = "lblNosotros";
            lblNosotros.Size = new Size(183, 32);
            lblNosotros.TabIndex = 81;
            lblNosotros.Text = "NOSOTROS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(119, 923);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(228, 58);
            btnSalir.TabIndex = 82;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // iconoSalir
            // 
            iconoSalir.BackColor = Color.IndianRed;
            iconoSalir.Image = CIneLabo.Properties.Resources.boton_salir;
            iconoSalir.Location = new Point(36, 923);
            iconoSalir.Name = "iconoSalir";
            iconoSalir.Size = new Size(57, 54);
            iconoSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoSalir.TabIndex = 83;
            iconoSalir.TabStop = false;
            iconoSalir.Click += iconoSalir_Click;
            // 
            // frmAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1924, 1055);
            Controls.Add(iconoSalir);
            Controls.Add(btnSalir);
            Controls.Add(lblNosotros);
            Controls.Add(lblReporte);
            Controls.Add(lblTransaccion);
            Controls.Add(lblSoporte);
            Controls.Add(iconoNosotros);
            Controls.Add(iconoReporte);
            Controls.Add(iconoTransaccion);
            Controls.Add(iconoSoporte);
            Controls.Add(lblMenu);
            Controls.Add(iconoMenu);
            Controls.Add(pbFondoMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdministrador";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbFondoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoSoporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoTransaccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoNosotros).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFondoMenu;
        private PictureBox iconoMenu;
        private Label lblMenu;
        private PictureBox iconoSoporte;
        private PictureBox iconoTransaccion;
        private PictureBox iconoReporte;
        private PictureBox iconoNosotros;
        private Label lblSoporte;
        private Label lblTransaccion;
        private Label lblReporte;
        private Label lblNosotros;
        public Button btnSalir;
        private PictureBox iconoSalir;
    }
}