﻿namespace SistemaControlChequesRev2
{
    partial class ResultadoGeneral
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
            dataGridView1 = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Beneficiario = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha_Emision = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Folio, Beneficiario, Monto, Fecha_Emision, Detalle });
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.Name = "Folio";
            // 
            // Beneficiario
            // 
            Beneficiario.HeaderText = "Beneficiario";
            Beneficiario.Name = "Beneficiario";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.HeaderText = "Fecha_Emision";
            Fecha_Emision.Name = "Fecha_Emision";
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            // 
            // button1
            // 
            button1.Location = new Point(597, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(687, 35);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 2;
            button2.Text = "<-- Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 3;
            label1.Text = "ventana de estado de cuenta";
            label1.Click += label1_Click;
            // 
            // ResultadoGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ResultadoGeneral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultadoGeneral";
            Load += ResultadoGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Beneficiario;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha_Emision;
        private DataGridViewTextBoxColumn Detalle;
    }
}