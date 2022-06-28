using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variáveis p/ armazenar os valores dos campos:
            double peso = 0;
            double altura = 0;
            double resultado = 0;

            // Iniciando o programa:
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                // Armazenando informações:
                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);
            }
            else
            {
                // Caso faltem dados a serem adicionados:
                MessageBox.Show("Adicione as informações necessárias.");
            }          
            // Cálculo:
            resultado = peso / (altura * altura);

            // Mostrando resultado:
            txtImc.Text = resultado.ToString();

            // Obtendo conclusão de acordo com o resultado:
            if (resultado <= 18.5)
            {
                lblConclusao.Text = "Abaixo do Peso.";
                lblConclusao.ForeColor = Color.Green;
            }
            else if(resultado >= 18.6 && resultado <= 24.9)
            {
                lblConclusao.Text = "Peso ideal.";
                lblConclusao.ForeColor = Color.Green;
            }
            else if(resultado >= 25 && resultado <= 29.9)
            {
                lblConclusao.Text = "Levemente acima do peso.";
                lblConclusao.ForeColor = Color.Orange;
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                lblConclusao.Text = "Obesidade grau I!";
                lblConclusao.ForeColor = Color.Orange;
            }
            else if (resultado >= 35 && resultado <= 39.9)
            {
                lblConclusao.Text = "Obesidade grau II (severa)!";
                lblConclusao.ForeColor = Color.Red;
            }
            else if (resultado >= 40)
            {
                lblConclusao.Text = "Obesidade III (mórbida)!";
                lblConclusao.ForeColor = Color.Red;
            }
        }
    }
}
