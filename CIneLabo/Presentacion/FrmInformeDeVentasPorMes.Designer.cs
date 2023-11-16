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
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(78, 139);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(139, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarInforme.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarInforme.Location = new Point(142, 266);
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
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 58);
            label4.Name = "label4";
            label4.Size = new Size(170, 17);
            label4.TabIndex = 14;
            label4.Text = "Debes seleccionar un:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 139);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 13;
            label3.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 12;
            label2.Text = "Desde";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(247, 168);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 29);
            label1.TabIndex = 10;
            label1.Text = "Informe de ventas ";
            label1.Click += label1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(19, 266);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmInformeDeVentasPorMes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(560, 301);
            Controls.Add(btnLimpiar);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnGenerarInforme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            ForeColor = Color.Black;
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
        private Label label1;
        private Button btnLimpiar;
    }
}