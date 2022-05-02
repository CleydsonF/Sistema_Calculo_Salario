using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_5_WindowsFormExercico_02_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdFreelancer_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            txtValorProjeto.Visible = true;
        }

        private void calcular_Click(object sender, EventArgs e)
        {

            string nome = txtColaborador.Text;
            double salario = double.Parse(txtSalario.Text);

            if (rdClt.Checked)
            {
                double desconto = salario  * 0.06;
                double valorLiquido = salario - desconto;
                calculo.Text = $" O Colaborador {txtColaborador.Text} irá receber: R$: "+ valorLiquido.ToString()+" reais";

            }
            else if (rdPj.Checked)
            {
                double desconto = salario * 0.06;
                double valorLiquido = salario - desconto;
                calculo.Text = $" O Colaborador {txtColaborador.Text} irá receber: R$: " + valorLiquido.ToString() + " reais";
            }
            else
            {
                double bonus = salario * 0.085;
                double valorLiquido = salario + bonus;
                calculo.Text = $" O Colaborador {txtColaborador.Text} irá receber: R$: " + valorLiquido.ToString() + " reais";
            }

            calculo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void apagar_Click(object sender, EventArgs e)
        {
            txtColaborador.Clear();
            txtSalario.Clear();
            txtValorProjeto.Clear();
            calculo.Visible = false;
            rdClt.Checked = false;
            rdPj.Checked = false;
            rdFreelancer.Checked = false;
        }
    }
}
