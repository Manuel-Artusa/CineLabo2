namespace CIneLabo.Presentacion
{
    partial class FrmPodio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPodio));
            dgvPodio = new DataGridView();
            Colposicion = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPuntos = new DataGridViewTextBoxColumn();
            txtSegundo = new TextBox();
            txtPrimero = new TextBox();
            txtTercero = new TextBox();
            gbSegundo = new GroupBox();
            gbPrimero = new GroupBox();
            gbTercero = new GroupBox();
            btnActualizar = new Button();
            cboGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPodio).BeginInit();
            SuspendLayout();
            // 
            // dgvPodio
            // 
            dgvPodio.AllowUserToAddRows = false;
            dgvPodio.AllowUserToDeleteRows = false;
            dgvPodio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodio.Columns.AddRange(new DataGridViewColumn[] { Colposicion, ColNombre, ColPuntos });
            dgvPodio.Location = new Point(12, 243);
            dgvPodio.Name = "dgvPodio";
            dgvPodio.ReadOnly = true;
            dgvPodio.RowTemplate.Height = 25;
            dgvPodio.Size = new Size(429, 218);
            dgvPodio.TabIndex = 0;
            dgvPodio.CellContentClick += dgvPodio_CellContentClick;
            // 
            // Colposicion
            // 
            Colposicion.HeaderText = "Posicion";
            Colposicion.Name = "Colposicion";
            Colposicion.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre y Apellido";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 150;
            // 
            // ColPuntos
            // 
            ColPuntos.HeaderText = "Puntos";
            ColPuntos.Name = "ColPuntos";
            ColPuntos.ReadOnly = true;
            ColPuntos.Width = 125;
            // 
            // txtSegundo
            // 
            txtSegundo.Enabled = false;
            txtSegundo.Location = new Point(41, 173);
            txtSegundo.Multiline = true;
            txtSegundo.Name = "txtSegundo";
            txtSegundo.ReadOnly = true;
            txtSegundo.Size = new Size(124, 43);
            txtSegundo.TabIndex = 1;
            // 
            // txtPrimero
            // 
            txtPrimero.Enabled = false;
            txtPrimero.Location = new Point(168, 122);
            txtPrimero.Multiline = true;
            txtPrimero.Name = "txtPrimero";
            txtPrimero.ReadOnly = true;
            txtPrimero.Size = new Size(124, 45);
            txtPrimero.TabIndex = 2;
            // 
            // txtTercero
            // 
            txtTercero.Enabled = false;
            txtTercero.Location = new Point(294, 185);
            txtTercero.Multiline = true;
            txtTercero.Name = "txtTercero";
            txtTercero.ReadOnly = true;
            txtTercero.Size = new Size(124, 44);
            txtTercero.TabIndex = 3;
            // 
            // gbSegundo
            // 
            gbSegundo.BackgroundImageLayout = ImageLayout.Zoom;
            gbSegundo.Location = new Point(75, 98);
            gbSegundo.Name = "gbSegundo";
            gbSegundo.Size = new Size(52, 69);
            gbSegundo.TabIndex = 4;
            gbSegundo.TabStop = false;
            // 
            // gbPrimero
            // 
            gbPrimero.AccessibleRole = AccessibleRole.None;
            gbPrimero.BackgroundImageLayout = ImageLayout.Zoom;
            gbPrimero.Location = new Point(205, 49);
            gbPrimero.Name = "gbPrimero";
            gbPrimero.Size = new Size(59, 67);
            gbPrimero.TabIndex = 5;
            gbPrimero.TabStop = false;
            // 
            // gbTercero
            // 
            gbTercero.BackgroundImageLayout = ImageLayout.Zoom;
            gbTercero.Location = new Point(330, 122);
            gbTercero.Name = "gbTercero";
            gbTercero.Size = new Size(55, 57);
            gbTercero.TabIndex = 5;
            gbTercero.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(304, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 30);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(75, 19);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 6;
            // 
            // FrmPodio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(453, 473);
            Controls.Add(cboGenero);
            Controls.Add(btnActualizar);
            Controls.Add(gbTercero);
            Controls.Add(gbPrimero);
            Controls.Add(gbSegundo);
            Controls.Add(txtTercero);
            Controls.Add(txtPrimero);
            Controls.Add(txtSegundo);
            Controls.Add(dgvPodio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(469, 512);
            MinimumSize = new Size(469, 512);
            Name = "FrmPodio";
            Text = "Podio";
            Load += FrmPodio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodio;
        private TextBox txtSegundo;
        private TextBox txtPrimero;
        private TextBox txtTercero;
        private GroupBox gbSegundo;
        private GroupBox gbPrimero;
        private GroupBox gbTercero;
        private DataGridViewTextBoxColumn Colposicion;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPuntos;
        private Button btnActualizar;
        private ComboBox cboGenero;
    }
}