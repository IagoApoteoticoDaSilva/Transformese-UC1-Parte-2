namespace WFinicial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnResultado = new Button();
            lblNota1 = new Label();
            txtNota1 = new TextBox();
            lblNota2 = new Label();
            txtNota2 = new TextBox();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.BackColor = SystemColors.ControlLight;
            btnResultado.Location = new Point(31, 158);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(242, 38);
            btnResultado.TabIndex = 0;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(31, 52);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(45, 15);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(107, 49);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(31, 107);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(45, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(107, 104);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 209);
            Controls.Add(txtNota2);
            Controls.Add(lblNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota1);
            Controls.Add(btnResultado);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResultado;
        private Label lblNota1;
        private TextBox txtNota1;
        private Label lblNota2;
        private TextBox txtNota2;
    }
}
