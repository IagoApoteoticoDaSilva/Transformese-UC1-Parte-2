namespace WFinicial
{
    partial class FormMenu
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(34, 40);
            btn1.Name = "btn1";
            btn1.Size = new Size(225, 65);
            btn1.TabIndex = 0;
            btn1.Text = "Exercicio 1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(34, 130);
            btn2.Name = "btn2";
            btn2.Size = new Size(225, 65);
            btn2.TabIndex = 1;
            btn2.Text = "Exercicio 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(34, 216);
            btn3.Name = "btn3";
            btn3.Size = new Size(225, 65);
            btn3.TabIndex = 2;
            btn3.Text = "Exercicio 3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click_1;
            // 
            // btn4
            // 
            btn4.Location = new Point(34, 301);
            btn4.Name = "btn4";
            btn4.Size = new Size(225, 65);
            btn4.TabIndex = 3;
            btn4.Text = "Exercicio 4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click_1;
            // 
            // btn7
            // 
            btn7.Location = new Point(363, 216);
            btn7.Name = "btn7";
            btn7.Size = new Size(225, 65);
            btn7.TabIndex = 6;
            btn7.Text = "Exercicio 7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click_1;
            // 
            // btn6
            // 
            btn6.Location = new Point(363, 130);
            btn6.Name = "btn6";
            btn6.Size = new Size(225, 65);
            btn6.TabIndex = 5;
            btn6.Text = "Exercicio 6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click_1;
            // 
            // btn5
            // 
            btn5.Location = new Point(363, 40);
            btn5.Name = "btn5";
            btn5.Size = new Size(225, 65);
            btn5.TabIndex = 4;
            btn5.Text = "Exercicio 5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click_1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 405);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn7;
        private Button btn6;
        private Button btn5;
    }
}