using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFinicial
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(num3, maior);

            int menor = Math.Min(num1, num2);
            menor = Math.Min(num3, menor);

            string mensagemMaior = $"O Número {menor} é o menor número!";
            string mensagemMenor = $"O Número {maior} é o maior número!";

            MessageBox.Show(mensagemMaior, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show(mensagemMenor, "Info",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
