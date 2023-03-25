namespace SistemaControlChequesRev2
{
    partial class Buscar
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
            cbxBuscar = new ComboBox();
            label1 = new Label();
            btnSeleccion = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbxBuscar
            // 
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Items.AddRange(new object[] { "Nombre", "Fecha", "Monto", "Detalle", "Folio" });
            cbxBuscar.Location = new Point(12, 43);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(121, 23);
            cbxBuscar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(151, 42);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 2;
            btnSeleccion.Text = "Seleccionar";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(232, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(319, 81);
            Controls.Add(btnCancel);
            Controls.Add(btnSeleccion);
            Controls.Add(label1);
            Controls.Add(cbxBuscar);
            Name = "Buscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            Load += Buscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxBuscar;
        private Label label1;
        private Button btnSeleccion;
        private Button btnCancel;
    }
}