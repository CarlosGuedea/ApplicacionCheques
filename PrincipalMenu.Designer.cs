namespace SistemaControlChequesRev2
{
    partial class PrincipalMenu
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
            btnExpedirCheque = new Button();
            btnBuscar = new Button();
            btnDeposito = new Button();
            btnFolios = new Button();
            btnReportes = new Button();
            btnLogout = new Button();
            lblNombre = new Label();
            lblNoCuenta = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnExpedirCheque
            // 
            btnExpedirCheque.Location = new Point(36, 264);
            btnExpedirCheque.Name = "btnExpedirCheque";
            btnExpedirCheque.Size = new Size(146, 67);
            btnExpedirCheque.TabIndex = 0;
            btnExpedirCheque.Text = "Expedir cheque";
            btnExpedirCheque.UseVisualStyleBackColor = true;
            btnExpedirCheque.Click += btnExpedirCheque_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(188, 264);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 67);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(340, 264);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(146, 67);
            btnDeposito.TabIndex = 2;
            btnDeposito.Text = "Depositos";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnFolios
            // 
            btnFolios.Location = new Point(492, 264);
            btnFolios.Name = "btnFolios";
            btnFolios.Size = new Size(146, 67);
            btnFolios.TabIndex = 3;
            btnFolios.Text = "Folios";
            btnFolios.UseVisualStyleBackColor = true;
            btnFolios.Click += btnFolios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(644, 264);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(146, 67);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(824, 272);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 50);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblNoCuenta
            // 
            lblNoCuenta.AutoSize = true;
            lblNoCuenta.Location = new Point(46, 60);
            lblNoCuenta.Name = "lblNoCuenta";
            lblNoCuenta.Size = new Size(64, 15);
            lblNoCuenta.TabIndex = 7;
            lblNoCuenta.Text = "No.Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "No.Folio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(693, 25);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Saldo disponible:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(678, 41);
            label5.Name = "label5";
            label5.Size = new Size(181, 65);
            label5.TabIndex = 10;
            label5.Text = "10,000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(865, 76);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 11;
            label6.Text = "Mxn";
            // 
            // PrincipalMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 346);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNoCuenta);
            Controls.Add(lblNombre);
            Controls.Add(btnLogout);
            Controls.Add(btnReportes);
            Controls.Add(btnFolios);
            Controls.Add(btnDeposito);
            Controls.Add(btnBuscar);
            Controls.Add(btnExpedirCheque);
            Name = "PrincipalMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalMenu";
            Load += PrincipalMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExpedirCheque;
        private Button btnBuscar;
        private Button btnDeposito;
        private Button btnFolios;
        private Button btnReportes;
        private Button btnLogout;
        private Label lblNombre;
        private Label lblNoCuenta;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}