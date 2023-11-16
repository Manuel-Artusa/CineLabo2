namespace CIneLabo.Presentacion
{
    partial class FrmInformeMejoresFormasDePago
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
            btnLimpiar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnGenerarInforme = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvFormasDePago = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFormasDePago).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(34, 275);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(93, 148);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(139, 23);
            dtpHasta.TabIndex = 26;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(93, 105);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(139, 23);
            dtpDesde.TabIndex = 25;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarInforme.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarInforme.Location = new Point(157, 275);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(75, 23);
            btnGenerarInforme.TabIndex = 24;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 67);
            label4.Name = "label4";
            label4.Size = new Size(170, 17);
            label4.TabIndex = 23;
            label4.Text = "Debes seleccionar un:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 148);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 22;
            label3.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 21;
            label2.Text = "Desde";
            // 
            // dgvFormasDePago
            // 
            dgvFormasDePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormasDePago.Location = new Point(258, 67);
            dgvFormasDePago.Name = "dgvFormasDePago";
            dgvFormasDePago.RowTemplate.Height = 25;
            dgvFormasDePago.Size = new Size(247, 168);
            dgvFormasDePago.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(126, 18);
            label1.Name = "label1";
            label1.Size = new Size(379, 29);
            label1.TabIndex = 19;
            label1.Text = "MEJORES FORMAS DE PAGO ";
            // 
            // FrmInformeMejoresFormasDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 312);
            Controls.Add(btnLimpiar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(btnGenerarInforme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvFormasDePago);
            Controls.Add(label1);
            Name = "FrmInformeMejoresFormasDePago";
            Text = "FrmInformeMejoresFormasDePago";
            Load += FrmInformeMejoresFormasDePago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFormasDePago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnGenerarInforme;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvFormasDePago;
        private Label label1;
    }
}