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
            textBox2 = new TextBox();
            txtValorDolarActual = new TextBox();
            lblValDolAnt = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(370, 31);
            button1.Name = "button1";
            button1.Size = new Size(137, 47);
            button1.TabIndex = 0;
            button1.Text = "Calcular Precio Sugerido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(370, 252);
            button2.Name = "button2";
            button2.Size = new Size(137, 28);
            button2.TabIndex = 1;
            button2.Text = "Actualizar Precio";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtDolarAntes
            // 
            txtDolarAntes.Location = new Point(30, 55);
            txtDolarAntes.Name = "txtDolarAntes";
            txtDolarAntes.Size = new Size(108, 23);
            txtDolarAntes.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(393, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 23);
            textBox2.TabIndex = 3;
            // 
            // txtValorDolarActual
            // 
            txtValorDolarActual.Location = new Point(210, 55);
            txtValorDolarActual.Name = "txtValorDolarActual";
            txtValorDolarActual.Size = new Size(102, 23);
            txtValorDolarActual.TabIndex = 4;
            // 
            // lblValDolAnt
            // 
            lblValDolAnt.AutoSize = true;
            lblValDolAnt.BackColor = Color.Silver;
            lblValDolAnt.Location = new Point(30, 27);
            lblValDolAnt.Name = "lblValDolAnt";
            lblValDolAnt.Size = new Size(108, 15);
            lblValDolAnt.TabIndex = 5;
            lblValDolAnt.Text = "Valor Dolar anterior";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(210, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Valor Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(393, 103);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Precio Sugerido";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColPrecio });
            dataGridView1.Location = new Point(30, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(294, 254);
            dataGridView1.TabIndex = 8;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 150;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // FrmActualizacionPrecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(546, 416);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValDolAnt);
            Controls.Add(txtValorDolarActual);
            Controls.Add(textBox2);
            Controls.Add(txtDolarAntes);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmActualizacionPrecio";
            Text = "Actualizacion Precio Entradas";
            Load += FrmActualizacionPrecio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtDolarAntes;
        private TextBox textBox2;
        private TextBox txtValorDolarActual;
        private Label lblValDolAnt;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}