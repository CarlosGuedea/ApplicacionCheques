namespace SistemaControlChequesRev2
{
    partial class ExpedirCheque
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
            Monto = new TextBox();
            Detalle = new TextBox();
            Folio = new TextBox();
            lblNombreBenef = new Label();
            lblFecha = new Label();
            lblMonto = new Label();
            lblConcepto = new Label();
            lblFolio = new Label();
            dateTimePicker1 = new DateTimePicker();
            Nombre = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(373, 288);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(473, 288);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Monto
            // 
            Monto.Location = new Point(197, 145);
            Monto.Name = "Monto";
            Monto.Size = new Size(351, 23);
            Monto.TabIndex = 6;
            // 
            // Detalle
            // 
            Detalle.ImeMode = ImeMode.NoControl;
            Detalle.Location = new Point(197, 186);
            Detalle.Name = "Detalle";
            Detalle.Size = new Size(351, 23);
            Detalle.TabIndex = 7;
            Detalle.TextChanged += textBox6_TextChanged;
            // 
            // Folio
            // 
            Folio.Location = new Point(197, 225);
            Folio.Name = "Folio";
            Folio.Size = new Size(351, 23);
            Folio.TabIndex = 8;
            Folio.TextChanged += textBox7_TextChanged;
            // 
            // lblNombreBenef
            // 
            lblNombreBenef.AutoSize = true;
            lblNombreBenef.Location = new Point(40, 69);
            lblNombreBenef.Name = "lblNombreBenef";
            lblNombreBenef.Size = new Size(135, 15);
            lblNombreBenef.TabIndex = 9;
            lblNombreBenef.Text = "Nombre del beneficiario";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(40, 112);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(40, 153);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(40, 189);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 12;
            lblConcepto.Text = "Concepto";
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Location = new Point(40, 233);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(33, 15);
            lblFolio.TabIndex = 13;
            lblFolio.Text = "Folio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(195, 66);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(353, 23);
            Nombre.TabIndex = 15;
            // 
            // ExpedirCheque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 334);
            Controls.Add(Nombre);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFolio);
            Controls.Add(lblConcepto);
            Controls.Add(lblMonto);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreBenef);
            Controls.Add(Folio);
            Controls.Add(Detalle);
            Controls.Add(Monto);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ExpedirCheque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpedirCheque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Monto;
        private TextBox Detalle;
        private TextBox Folio;
        private Label lblNombreBenef;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblConcepto;
        private Label lblFolio;
        private DateTimePicker dateTimePicker1;
        private TextBox Nombre;
    }
}