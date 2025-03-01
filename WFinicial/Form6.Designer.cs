namespace WFinicial
{
    partial class Form6
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
            txtSalario = new TextBox();
            txtNome = new TextBox();
            lblSalario = new Label();
            lblNome = new Label();
            btnResultado = new Button();
            txtHoras = new TextBox();
            lblHoras = new Label();
            SuspendLayout();
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(159, 64);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(109, 23);
            txtSalario.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(159, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(108, 23);
            txtNome.TabIndex = 8;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(43, 67);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(93, 15);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salário por hora:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(43, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(87, 160);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(102, 39);
            btnResultado.TabIndex = 5;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(158, 101);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(109, 23);
            txtHoras.TabIndex = 11;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(43, 104);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(105, 15);
            lblHoras.TabIndex = 10;
            lblHoras.Text = "Horas trabalhadas:";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 211);
            Controls.Add(txtHoras);
            Controls.Add(lblHoras);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(lblSalario);
            Controls.Add(lblNome);
            Controls.Add(btnResultado);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalario;
        private TextBox txtNome;
        private Label lblSalario;
        private Label lblNome;
        private Button btnResultado;
        private TextBox txtHoras;
        private Label lblHoras;
    }
}