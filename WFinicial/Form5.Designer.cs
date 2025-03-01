namespace WFinicial
{
    partial class Form5
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
            txtNum3 = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblNum3 = new Label();
            lblNum2 = new Label();
            lblNum1 = new Label();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(17, 149);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(207, 38);
            btnResultado.TabIndex = 13;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(112, 72);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(112, 23);
            txtNum3.TabIndex = 12;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(112, 43);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(112, 23);
            txtNum2.TabIndex = 11;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(112, 13);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(112, 23);
            txtNum1.TabIndex = 10;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(17, 80);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(63, 15);
            lblNum3.TabIndex = 9;
            lblNum3.Text = "Numero 3:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(17, 51);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 8;
            lblNum2.Text = "Numero 2:";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(17, 21);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 7;
            lblNum1.Text = "Numero 1:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 200);
            Controls.Add(btnResultado);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResultado;
        private TextBox txtNum3;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblNum3;
        private Label lblNum2;
        private Label lblNum1;
    }
}