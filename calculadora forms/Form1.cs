nusing System;
using System.Windows.Forms;

namespace Calculadora_Forms
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (txtScreen.Text == "0")
                txtScreen.Text = "";
            txtScreen.Text += btn.Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            valor1 = double.Parse(txtScreen.Text);
            operacao = btn.Text;
            txtScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtScreen.Text);
            switch (operacao)
            {
                case "+":
                    txtScreen.Text = (valor1 + valor2).ToString();
                    break;
                case "-":
                    txtScreen.Text = (valor1 - valor2).ToString();
                    break;
                case "*":
                    txtScreen.Text = (valor1 * valor2).ToString();
                    break;
                case "/":
                    txtScreen.Text = (valor1 / valor2).ToString();
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
            valor1 = valor2 = 0;
            operacao = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
            if (txtScreen.Text == "") ;
                txtScreen.Text = "0";
        }
    }
}
