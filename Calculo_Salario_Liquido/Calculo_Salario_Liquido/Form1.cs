using System;
using System.Globalization;

namespace Calculo_Salario_Liquido
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string textoSalario = txtSalario.Text.ToString(new CultureInfo("pt-br"));

            lblSalario.Text = ""+  double.Parse(textoSalario);
            AliquotasINSS(double.Parse(lblSalario.Text)) ;
           
        }

        public void AliquotasINSS(double Salario)
        {
            double INSS = 0;

            double[] faixa1Aliquota = { 0,  82.50, 99.31, 132.20, 437.97 };
            double[] calculo1Aliquota = { (0.075), (0.09), (.12), (.14) };

            double[] faixa1 = { 1100.00, calculo1Aliquota[0], (Salario), 82.50  };
            double[] faixa2 = { 2203.48, calculo1Aliquota[1], (Salario - faixa1[0]), 99.31 };
            double[] faixa3 = { 3305.22, calculo1Aliquota[2], (Salario - faixa2[0]), 132.20 };
            double[] faixa4 = { 6433.57, calculo1Aliquota[3], (Salario - faixa3[0]), 437.97 };

            if (Salario > faixa4[0])
            {
                lblNSS.Text = "Valor acima do teto maximo";
            }
            else
            {
                if(Salario > faixa3[0] && Salario <= faixa4[0])
                {
                    INSS = (faixa4[2] * faixa4[1]) + faixa1Aliquota[1]+ faixa1Aliquota[2] + faixa1Aliquota[3];
                    lblNSS.Text = "R$ 3.305,23 até R$ 6.433,57 e o valor do INSS é de R$ " + Math.Round(INSS, 2);
                }
                if (Salario > faixa2[0] && Salario <= faixa3[0])
                {
                    INSS = (faixa3[2] * faixa3[1]) + faixa1Aliquota[1] + faixa1Aliquota[2];

                    lblNSS.Text = "R$ 2.203,49 até R$ 3.305,22 e o valor do INSS é de R$ " + Math.Round(INSS, 2);
                }
                if (Salario > faixa1[0] && Salario <= faixa2[0])
                {
                    INSS = (faixa2[2] * faixa2[1]) + faixa1Aliquota[1];

                    lblNSS.Text = "R$ 1.100,01 até R$ 2.203,48 e o valor do INSS é de R$ " + Math.Round(INSS, 2);
                }
                if (Salario <= faixa1[0])
                { 

                    INSS = Salario * faixa1[1];
                    lblNSS.Text = "até R$ 1.100,00 e o valor do INSS é de R$" + Math.Round(INSS,2 );
                }

                

            }

            AliquotaIRRF(Salario, INSS);

            

        }

        public void AliquotaIRRF(double Salario, double INSS)
        {

            
            double[] faixa1AiquotaIRRF =  { 0      ,       0, (.075),  (.15), (.225), (.275) };
            double[] faixa1DescontoIRRF = { 0      ,       0, 142.80, 354.80, 636.13, 869.36 };
            double[] faixasSalarialIRRF = { 0      , 1903.98,2826.65, 3751.05, 4664.68, 4664.69 };

            double SalarioBase = Salario - INSS;
            double IRRF = 0;

            if( SalarioBase >= faixasSalarialIRRF[5])
            {
                IRRF = ((SalarioBase * faixa1AiquotaIRRF[4]) - faixa1DescontoIRRF[4]);
                lblIRRF.Text = "a partir de R$ 4.664,68 o valor do IRRF é de R$ " + Math.Round(IRRF, 2);

            }
            else
            {
                if (SalarioBase > faixasSalarialIRRF[3] && SalarioBase <= faixasSalarialIRRF[4])
                {

                    IRRF = ((SalarioBase * faixa1AiquotaIRRF[3]) - faixa1DescontoIRRF[3]);
                    lblIRRF.Text = "de R$ 3.751,06 até R$ 4.664,68 o valor do IRRF é de R$ " + Math.Round(IRRF, 2);


                }

                if (SalarioBase > faixasSalarialIRRF[2] && SalarioBase <= faixasSalarialIRRF[3])
                {

                    IRRF = ((SalarioBase * faixa1AiquotaIRRF[3]) - faixa1DescontoIRRF[3]);
                    lblIRRF.Text = "de R$ 2.826,66 até R$ 3.751,05 o valor do IRRF é de R$ " + Math.Round(IRRF, 2);


                }
                if (SalarioBase > faixasSalarialIRRF[1] && SalarioBase <= faixasSalarialIRRF[2])
                {
                    IRRF = (( SalarioBase * faixa1AiquotaIRRF[2]) - faixa1DescontoIRRF[2]);
                    lblIRRF.Text = "de R$ 1.903,99 até R$ 2.826,65 o valor do IRRF é de R$ " + Math.Round(IRRF, 2);



                }
                if (SalarioBase <= faixasSalarialIRRF[1] )
                {

                    IRRF = 0;
                    lblIRRF.Text = "de R$ 0,00 até R$ 1.903,98 o valor do IRRF é de INSENTO";


                }
                               
            }


                lblSalarioLiquido.Text = "O Salário liquido é de R$ " + Math.Round(SalarioBase - (IRRF),2);


        }


    }
}