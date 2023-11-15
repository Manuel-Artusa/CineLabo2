namespace CIneLabo.Presentacion
{
    partial class FrmInformeDeVentasPorMes
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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btnGenerarInforme = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Total_Ventas = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(58, 119);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(139, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(58, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(65, 198);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(75, 23);
            btnGenerarInforme.TabIndex = 15;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 42);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 14;
            label4.Text = "Debes seleccionar un:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 119);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 13;
            label3.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Desde";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Total_Ventas, Mes, Anio });
            dataGridView1.Location = new Point(211, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 168);
            dataGridView1.TabIndex = 11;
            // 
            // Total_Ventas
            // 
            Total_Ventas.HeaderText = "Total de ventas";
            Total_Ventas.Name = "Total_Ventas";
            Total_Ventas.Width = 150;
            // 
            // Mes
            // 
            Mes.HeaderText = "Mes";
            Mes.Name = "Mes";
            Mes.Width = 150;
            // 
            // Anio
            // 
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            Anio.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 10;
            label1.Text = "Informe de ventas ";
            // 
            // FrmInformeDeVentasPorMes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 301);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnGenerarInforme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmInformeDeVentasPorMes";
            Text = "FrmInformeDeVentasPorMes";
            Load += FrmInformeDeVentasPorMes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnGenerarInforme;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Total_Ventas;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn Anio;
        private Label label1;
    }
}