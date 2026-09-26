using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor = 0, valor2 = 0;
        string operacao = "";

        //cultura brasileira: usa Vírgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //Indica se o ultimo comando foi o botão = 
        bool novoCalculo = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSete_Click(object sender, EventArgs e)
        {

        }

        private void btnOito_Click(object sender, EventArgs e)
        {

        }

        private void btnNove_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void btnCe_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
           
        }
        
     
    }
}
