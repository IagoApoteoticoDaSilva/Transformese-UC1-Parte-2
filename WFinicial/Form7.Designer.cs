namespace WFinicial
{
    partial class Form7
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblCompras = new Label();
            lblItem1 = new Label();
            lblItem2 = new Label();
            lblItem4 = new Label();
            lblItem3 = new Label();
            lblItem6 = new Label();
            lblItem5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(75, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(186, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCompras.Location = new Point(134, 84);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(112, 34);
            lblCompras.TabIndex = 2;
            lblCompras.Text = "Compras";
            // 
            // lblItem1
            // 
            lblItem1.AutoSize = true;
            lblItem1.Location = new Point(75, 166);
            lblItem1.Name = "lblItem1";
            lblItem1.Size = new Size(45, 15);
            lblItem1.TabIndex = 3;
            lblItem1.Text = "1° item";
            // 
            // lblItem2
            // 
            lblItem2.AutoSize = true;
            lblItem2.Location = new Point(75, 206);
            lblItem2.Name = "lblItem2";
            lblItem2.Size = new Size(45, 15);
            lblItem2.TabIndex = 4;
            lblItem2.Text = "2° item";
            // 
            // lblItem4
            // 
            lblItem4.AutoSize = true;
            lblItem4.Location = new Point(75, 281);
            lblItem4.Name = "lblItem4";
            lblItem4.Size = new Size(45, 15);
            lblItem4.TabIndex = 6;
            lblItem4.Text = "4° item";
            // 
            // lblItem3
            // 
            lblItem3.AutoSize = true;
            lblItem3.Location = new Point(75, 241);
            lblItem3.Name = "lblItem3";
            lblItem3.Size = new Size(45, 15);
            lblItem3.TabIndex = 5;
            lblItem3.Text = "3° item";
            // 
            // lblItem6
            // 
            lblItem6.AutoSize = true;
            lblItem6.Location = new Point(75, 361);
            lblItem6.Name = "lblItem6";
            lblItem6.Size = new Size(45, 15);
            lblItem6.TabIndex = 8;
            lblItem6.Text = "6° item";
            // 
            // lblItem5
            // 
            lblItem5.AutoSize = true;
            lblItem5.Location = new Point(75, 324);
            lblItem5.Name = "lblItem5";
            lblItem5.Size = new Size(45, 15);
            lblItem5.TabIndex = 7;
            lblItem5.Text = "5° item";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(166, 361);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(166, 321);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 13;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(75, 412);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(265, 44);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 468);
            Controls.Add(btnResultado);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblItem6);
            Controls.Add(lblItem5);
            Controls.Add(lblItem4);
            Controls.Add(lblItem3);
            Controls.Add(lblItem2);
            Controls.Add(lblItem1);
            Controls.Add(lblCompras);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCompras;
        private Label lblItem1;
        private Label lblItem2;
        private Label lblItem4;
        private Label lblItem3;
        private Label lblItem6;
        private Label lblItem5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnResultado;
    }
}