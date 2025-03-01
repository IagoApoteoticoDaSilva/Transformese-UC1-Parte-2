﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double valorHora = Convert.ToDouble(txtSalario.Text);
            int quantHoras = Convert.ToInt32(txtHoras.Text);
            double resultado = valorHora * quantHoras;

            string mensagem = $"A renda total de {nome} é R$ {resultado:F2}";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
