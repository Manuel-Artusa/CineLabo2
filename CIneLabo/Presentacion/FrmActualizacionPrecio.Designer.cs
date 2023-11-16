namespace CIneLabo.Presentacion
{
    partial class FrmActualizacionPrecio
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
            button1 = new Button();
            button2 = new Button();
            txtDolarAntes = new TextBox();
            txtPorcentaje = new TextBox();
            txtValorDolarActual = new TextBox();
            lblValDolAnt = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvPeliPrecio = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPeliPrecio).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(423, 41);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 63);
            button1.TabIndex = 0;
            button1.Text = "Calcular Precio Sugerido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 336);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(157, 37);
            button2.TabIndex = 1;
            button2.Text = "Actualizar Precio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // txtDolarAntes
            // 
            txtDolarAntes.Location = new Point(34, 73);
            txtDolarAntes.Margin = new Padding(3, 4, 3, 4);
            txtDolarAntes.Name = "txtDolarAntes";
            txtDolarAntes.Size = new Size(123, 27);
            txtDolarAntes.TabIndex = 2;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(449, 184);
            txtPorcentaje.Margin = new Padding(3, 4, 3, 4);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(102, 27);
            txtPorcentaje.TabIndex = 3;
            // 
            // txtValorDolarActual
            // 
            txtValorDolarActual.Location = new Point(240, 73);
            txtValorDolarActual.Margin = new Padding(3, 4, 3, 4);
            txtValorDolarActual.Name = "txtValorDolarActual";
            txtValorDolarActual.Size = new Size(116, 27);
            txtValorDolarActual.TabIndex = 4;
            // 
            // lblValDolAnt
            // 
            lblValDolAnt.AutoSize = true;
            lblValDolAnt.BackColor = Color.Silver;
            lblValDolAnt.Location = new Point(34, 36);
            lblValDolAnt.Name = "lblValDolAnt";
            lblValDolAnt.Size = new Size(140, 20);
            lblValDolAnt.TabIndex = 5;
            lblValDolAnt.Text = "Valor Dolar anterior";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(240, 36);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Valor Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(449, 137);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 7;
            label2.Text = "Precio Sugerido";
            // 
            // dgvPeliPrecio
            // 
            dgvPeliPrecio.AllowUserToAddRows = false;
            dgvPeliPrecio.AllowUserToDeleteRows = false;
            dgvPeliPrecio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliPrecio.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColPrecio });
            dgvPeliPrecio.Location = new Point(34, 157);
            dgvPeliPrecio.Margin = new Padding(3, 4, 3, 4);
            dgvPeliPrecio.Name = "dgvPeliPrecio";
            dgvPeliPrecio.ReadOnly = true;
            dgvPeliPrecio.RowHeadersWidth = 51;
            dgvPeliPrecio.RowTemplate.Height = 25;
            dgvPeliPrecio.Size = new Size(336, 339);
            dgvPeliPrecio.TabIndex = 8;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.MinimumWidth = 6;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 150;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 125;
            // 
            // FrmActualizacionPrecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(624, 555);
            Controls.Add(dgvPeliPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValDolAnt);
            Controls.Add(txtValorDolarActual);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtDolarAntes);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmActualizacionPrecio";
            Text = "Actualizacion Precio Entradas";
            Load += FrmActualizacionPrecio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtDolarAntes;
        private TextBox txtPorcentaje;
        private TextBox txtValorDolarActual;
        private Label lblValDolAnt;
        private Label label1;
        private Label label2;
        private DataGridView dgvPeliPrecio;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}