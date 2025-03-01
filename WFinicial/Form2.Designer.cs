namespace WFinicial
{
    partial class Form2
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
            btnResultado = new Button();
            lblNumero = new Label();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(101, 140);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(120, 50);
            btnResultado.TabIndex = 0;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(32, 61);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero:";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(101, 58);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(143, 23);
            txtDia.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 202);
            Controls.Add(txtDia);
            Controls.Add(lblNumero);
            Controls.Add(btnResultado);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResultado;
        private Label lblNumero;
        public TextBox txtDia;
    }
}