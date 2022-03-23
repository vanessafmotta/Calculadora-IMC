using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class FrmPrincipal : Form
    {
        private object lbResultadoIMC;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Imc imc = new Imc();
            imc.Altura = float.Parse(txtAltura.Text);
            imc.Peso = float.Parse(txtPeso.Text);
            float resultadoIMC = imc.calculaImc();

            lbResultadoIMC.text = "IMC: " + resultadoIMC.ToString("0.00");
            lbResultadoIMC.Visible = true;

            lbClassificacao.Text = "Classificação: " + imc.classificaIMC(resultadoIMC);
            lbClassificacao.Visible = true;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
