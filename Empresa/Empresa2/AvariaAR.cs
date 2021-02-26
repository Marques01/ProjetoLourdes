using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.IO;
using MySql;
using MySqlX;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace Empresa2
{

  
    public partial class AvariaAR : Form
    {
        string av = "O valor total da avaria foi de R$:";
        

        Calcular1722 c1722 = new Calcular1722();
        CalcularArCondiconado car = new CalcularArCondiconado();
        CalcularDianteira_Traseira cdt = new CalcularDianteira_Traseira();
        Calcular1519 c1519 = new Calcular1519();
        Produtos P = new Produtos();

        OpenFileDialog openF = new OpenFileDialog();              
    

        public AvariaAR()
        {

            InitializeComponent();                 

        }

        private void button1_Click(object sender, EventArgs e) // Botão de nova avaria
        {
            
        }  
               

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (check3Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) CARROCERIA / PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check1Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }

            if (check1Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Carroceria Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }


            // Traseira


            if (check2Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da traseira 2 PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check2Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da traseira 2 CARROCERIA PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check4Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Carroceria / Pintura CHECK4
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque traseiro CHECK 5 Recuperado
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque traseiro Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D Carroceria / pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }






            // Lado Direito 1519

            if (check0LD.Checked == false && check1LD.Checked.Equals(true) && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check1 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check1_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked.Equals(true) && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check2 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check2_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked.Equals(true) && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check3 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check3_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked.Equals(true) && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check4 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check4_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked.Equals(true) && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check5 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check5_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked.Equals(true) && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check6 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check6_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked.Equals(true)
               && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
               && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
               && check3Frente.Checked == false && check4Frente.Checked == false
               && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
               && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
               && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
               && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check7 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check7_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked.Equals(true) && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check8 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check8_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked.Equals(true) && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check9 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check9_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked.Equals(true) && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check10 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check10_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked.Equals(true) && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check11 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check11_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked.Equals(true) && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check12 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check12_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked.Equals(true)
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check13 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check13_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked.Equals(true) && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check14 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check14_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked.Equals(true) && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check15 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check15_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            // Lado Esquerdo 1519

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                            && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                            && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                            && check3Frente.Checked == false && check4Frente.Checked == false
                            && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked.Equals(true) && check2LE.Checked == false
                            && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                            && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                            && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check1 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check1LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked.Equals(true)
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check2 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check2LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked.Equals(true) && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check3 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check3LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                            && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                            && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                            && check3Frente.Checked == false && check4Frente.Checked == false
                            && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                            && check3LE.Checked == false && check4LE.Checked.Equals(true) && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                            && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                            && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check4 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check4LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked.Equals(true) && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check5 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check5LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked.Equals(true) && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check6 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check6LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked.Equals(true) && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check7 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check7LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked.Equals(true) && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check8 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check8LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked.Equals(true)
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check9 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check9LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked.Equals(true) && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check10 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check10LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked.Equals(true) && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check11 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check11LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked.Equals(true) && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check12 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check12LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked.Equals(true) && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check13 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check13LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked.Equals(true) && check15LE.Checked == false && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check14 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check14LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked.Equals(true) && check16LE.Checked == false
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check15 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check15LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked == false && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false
                && check8LD.Checked == false && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false
                && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false
                && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false
                && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false && check9LE.Checked == false
                && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked.Equals(true)
                && check17LE.Checked == false && check18LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // Valor cobrado somente com Check16 selecionado
            {
                MessageBox.Show(av + Math.Round(c1519.total_check16LE_1519(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check0LD.Checked.Equals(false) && check1LD.Checked == false && check2LD.Checked == false && check3LD.Checked == false && check4LD.Checked == false && check5LD.Checked == false && check6LD.Checked == false && check7LD.Checked == false && check8LD.Checked == false
             && check9LD.Checked == false && check10LD.Checked == false && check11LD.Checked == false && check12LD.Checked == false && check13LD.Checked == false && check14LD.Checked == false && check15LD.Checked == false && check16LD.Checked == false
             && check17LD.Checked == false && check1Frente.Checked == false && check2Frente.Checked == false
                && check3Frente.Checked == false && check4Frente.Checked == false && check1Tr.Checked == false && check2Tr.Checked == false && check3Tr.Checked == false && check4Tr.Checked == false && check5Tr.Checked == false && check6Tr.Checked == false && check1LE.Checked == false && check2LE.Checked == false && check3LE.Checked == false && check4LE.Checked == false && check5LE.Checked == false && check6LE.Checked == false && check7LE.Checked == false && check8LE.Checked == false
             && check9LE.Checked == false && check10LE.Checked == false && check11LE.Checked == false && check12LE.Checked == false && check13LE.Checked == false && check14LE.Checked == false && check15LE.Checked == false && check16LE.Checked == false && check17LE.Checked == false
             && check18LE.Checked == false && check19LE.Checked == false && checkCP.Checked.Equals(true) && checkP.Checked == false && tsTxtModelo.Text.Equals("1519")) // coluna traseira esquerda CARROCERIA / PINTURA
            {
                MessageBox.Show(av + Math.Round(c1519.colunaTECP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }
        }


        private void btn2LD_CheckedChanged(object sender, EventArgs e) // Radio Button Lado Direito
        {

            AvariaAR.ActiveForm.Refresh();

            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Direito estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Direito do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem
            }

            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado direito estiver marcado e o modelo de carro for ar condicionado quando apertar enter a foto muda para direita do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado1;
            }

            // =============== Dianteira =================== 

            foreach (Component Controls in pnlCheckFrente.Controls)
            {
                (Controls as CheckBox).Checked = false; // Desmarca todas as checkbox da traseira
            }

            pnlCheckFrente.Visible = false; // Desativa a visibilidade do painel com os check da dianteira           


            // =============== Lado Esquerdo ===================                                            

            foreach (Component Controls in pnlCheckLE.Controls)
            {
                (Controls as CheckBox).Checked = false; // Desmarca todas as checkbox do lado direito
            }

            pnlCheckLE.Visible = false; // Desativa o painel com os Checks do Lado Esquerdo


            // =============== Traseira ===================

            foreach (Component Controls in pnlCheckTraseira.Controls)
            {
                (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
            }

            pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira

        }

        private void rbLE_CheckedChanged(object sender, EventArgs e) // Radio Button lado esquerdo
        {
            AvariaAR.ActiveForm.Refresh();

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o número de ordem for modelo 1722 e o lado esquerdo estiver selecionado altera a imagem para 1722
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o número de ordem for modelo Ar condicionado e o lado esquerdo estiver selecionado altera a imagem para Ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado1; // Esquerda Sem número


            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes; // Esquerda Sem número
            }


            if (rbLE.Checked.Equals(true)) // Quando Lado esquerdo estiver marcado 
            {

                // =============== Dianteira =================== 

                foreach (Component Controls in pnlCheckFrente.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todas as checkbox da traseira
                }

                pnlCheckFrente.Visible = false; // Desativa a visibilidade do painel com os check da dianteira


                // =============== Lado direito ===================                                            

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todas as checkbox do lado direito
                }

                pnlCheckLD.Visible = false; // Desativa o painel com os Checks do Lado Direito                


                // =============== Traseira ===================

                foreach (Component Controls in pnlCheckTraseira.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
                }

                pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira

            }
        }

        private void rbDianteira_CheckedChanged(object sender, EventArgs e) // Radio button Dianteira
        {            

            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a frente estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para frente do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado1; // Frente ar condiconado sem numero

                AvariaAR.ActiveForm.Refresh();
            }

            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a frente estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para frente do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722; // Se a frente estiver marcada e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Refresh();
            }

            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes; // Se a dianteira estiver marcada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Refresh();
            }


            // =============== Traseira ===================

            foreach (Component Controls in pnlCheckTraseira.Controls)
            {
                (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
            }

            pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira

            // =============== Lado direito ===================

            foreach (Component Controls in pnlCheckLD.Controls)
            {
                (Controls as CheckBox).Checked = false; //Desmarca todas as check box do Lado Direito

            }


            pnlCheckLD.Visible = false;

            // =============== Lado Esquerdo =======================

            foreach (Component Controls in pnlCheckLE.Controls)
            {
                (Controls as CheckBox).Checked = false; // Desmarca todas as checkbox do Lado Esquerdo

            }

            pnlCheckLE.Visible = false; // Desativa a visibilidade do painel com os check do Lado Esquerdo
        }

        private void rbTraseira_CheckedChanged(object sender, EventArgs e)
        {

            AvariaAR.ActiveForm.Refresh();

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a traseira estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para traseira do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722; // Se a traseira estiver marcada e o modelo for 1722 altera a imagem
            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a traseira estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para traseira do ar condicionado)
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado1; // Se o a traseira estiver marcada e o modelo for Ar condicionado altera a imagem

            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519
            }

            if (rbTraseira.Checked.Equals(true))
            {

                // =============== Lado direito ===================

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Checked = false;
                }


                pnlCheckLD.Visible = false; // Desativa a vibilidade  do painel com os Check do Lado Direito


                // =============== Lado Esquerdo =======================

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do lado esquerdo
                }


                pnlCheckLE.Visible = false; //Desativa a visibilidade do painel com os Check Lado Esquerdo


                // =============== Dianteira =======================

                foreach (Component Controls in pnlCheckFrente.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da dianteira
                }

                pnlCheckFrente.Visible = false; // Desativa o painel com os check da dianteira

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            AvariaAR.ActiveForm.Close();
        }

        private void btnCalcular1722_Click(object sender, EventArgs e)
        {
            if (check3Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) CARROCERIA / PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check1Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }

            if (check1Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Carroceria Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }


            // Traseira


            if (check2Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da traseira 2 PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check2Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da traseira 2 CARROCERIA PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check4Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Carroceria / Pintura CHECK4
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque traseiro CHECK 5 Recuperado
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque traseiro Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D Carroceria / pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            // Lado Direito 1722

            if (check0LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado coluna traseira direita CARROCERIA / PINTURA
            {
                MessageBox.Show(av + Math.Round(c1722.total_check0_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check1 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check1_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check2LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check2 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check2_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check3 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check3_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check4 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check4_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check5 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check5_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com Check6 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check6_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check7LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check7 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check7_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check8LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check8 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check8_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check9LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check9 Lado Direito selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check9_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check10LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check10 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check10_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check11LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check11 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check11_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check12LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check12 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check12_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check13LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check13 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check13_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check14LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check14 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check14_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check15LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check15 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check15_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check16LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check16 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check16_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check17LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check17 selecionado
            {
                MessageBox.Show(av + Math.Round(c1722.total_check17_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            // Lado Esquerdo 1722


            if (check1LE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check1 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check1LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check2LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check2 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check2LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check3 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check3LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4LE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check17 selecionado // Valor cobrado somente com o check4 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check4LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check5 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check5LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check6 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check6LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check7LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check7 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check7LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check8LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check8 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check8LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check9LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check9 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check9LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check10LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check10 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check10LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check11LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check11 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check11LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check12LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check12 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check12LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check13LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check13 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check13LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor

            }

            if (check14LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check14 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check14LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check15LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check15 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check15LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check16LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check16 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check16LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check17LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check17 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check17LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check18LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check18 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check18LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check19LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Valor cobrado somente com o check19 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(c1722.total_check19LE_1722(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


        }

        private void AvariaAR_Load(object sender, EventArgs e)
        {
                          
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.vnslourdesDataSet.produtos);
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.vnslourdesDataSet.produtos);


            MySqlConnection mysqlC = new MySqlConnection("Server = localhost; Database = vnslourdes; Uid = root; Pwd = binario0101");
            MySqlCommand cmdmysql = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                cmdmysql.Connection = mysqlC;

                mysqlC.Open();

            }
            catch
            {

                MessageBox.Show("Não foi possível conectar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                if(pnlProdutos.Visible.Equals(true))
                {
                    P.chapa90 = Convert.ToDouble(chapa90TextBox.Text);

                    P.chapa75 = Convert.ToDouble(chapa75TextBox.Text);

                    P.washprimer = Convert.ToDouble(washprimerTextBox.Text);

                    P.catalizador = Convert.ToDouble(catalizadorTextBox.Text);

                    P.chapelco = Convert.ToDouble(chapelcoTextBox.Text);

                    P.m60 = Convert.ToDouble(m60TextBox.Text);

                    P.cidadeRJ = Convert.ToDouble(cidadeRJTextBox.Text);

                    P.internorte = Convert.ToDouble(internorteTextBox.Text);

                    P.nordem = Convert.ToDouble(nordemTextBox.Text);

                    P.nordemg = Convert.ToDouble(nordemgTextBox.Text);

                    P.nordemt = Convert.ToDouble(nordemtTextBox.Text);

                    P.papel = Convert.ToDouble(papelTextBox.Text);

                    P.capsula = Convert.ToDouble(capsulaTextBox.Text);

                    P.seta = Convert.ToDouble(setaTextBox.Text);

                    P.cadeirante = Convert.ToDouble(cadeiranteTextBox.Text);

                    P.faixarefletiva = Convert.ToDouble(faixarefletivaTextBox.Text);

                    P.peixinho = Convert.ToDouble(peixinhoTextBox.Text);

                    P.duplaface = Convert.ToDouble(duplafaceTextBox.Text);

                    P.fitafina = Convert.ToDouble(fitafinaTextBox.Text);

                    P.fitagrossa = Convert.ToDouble(fitagrossaTextBox.Text);

                    P.trincob = Convert.ToDouble(trincobTextBox.Text);

                    P.trincot = Convert.ToDouble(trincotTextBox.Text);

                    P.peixao = Convert.ToDouble(peixaoTextBox.Text);

                    P.dobradicaLD = Convert.ToDouble(dobradicaLDTextBox.Text);

                    P.dobradicaLE = Convert.ToDouble(dobradicaLETextBox.Text);

                    P.puxador = Convert.ToDouble(puxadorTextBox.Text);

                    P.massapoliester = Convert.ToDouble(massapoliesterTextBox.Text);

                    P.massafibra = Convert.ToDouble(massafibraTextBox.Text);

                    P.tintaverde = Convert.ToDouble(tintaverdeTextBox.Text);

                    P.redutor = Convert.ToDouble(redutorTextBox.Text);

                    P.cidadeRJgrade = Convert.ToDouble(cidadeRJgradeTextBox.Text);

                    P.disco80 = Convert.ToDouble(disco80TextBox.Text);

                    MessageBox.Show("Conectado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar os valores dos produtos", "Error #00001", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (check3Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque dianteiro (3) CARROCERIA / PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Dianteiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check2Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/D - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor                
            }

            if (check1Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }

            if (check1Frente.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da grade dianteira - Carroceria Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Grade_Dianteira_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor     
            }


            // Traseira


            if (check2Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da traseira 2 PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check2Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da traseira 2 CARROCERIA PINTURA
            {
                MessageBox.Show(av + Math.Round(cdt.Traseira_Meio_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor  
            }

            if (check4Frente.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira D/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_DD_DE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            if (check4Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 1 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da coluna traseira 3 - Carroceria / Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Coluna_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/E - Carroceria / Pintura CHECK4
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado do para choque traseiro CHECK 5 Recuperado
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D - Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5Tr.Checked.Equals(true) && checkP.Checked.Equals(true)) // Valor cobrado do para choque traseiro Pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Parachoque_Traseiro_P(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6Tr.Checked.Equals(true) && checkCP.Checked.Equals(true)) // Valor cobrado da ponteira traseira T/D Carroceria / pintura
            {
                MessageBox.Show(av + Math.Round(cdt.Ponteira_TD_TE_CP(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }


            // Lado Esquerdo Ar condiconado


            if (check1LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check1 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check1LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check2LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check2 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check2LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check3 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check3LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check4 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check4LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check5 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check5LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check6 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check6LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check7LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check7 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check7LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check8LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check8 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check8LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check9LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check9 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check9LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check10LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check10 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check10LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check11LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check11 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check11LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check12LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check12 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check12LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check13LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check13 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check13LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check14LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check14 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check14LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check15LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check15 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check15LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check16LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check16 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check16LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check17LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check17 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check17LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check18LE.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check18 Lado Esquerdo
            {
                MessageBox.Show(av + Math.Round(car.total_check18LE_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            // Lado Direito Ar condiconado            

            if (check0LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check0 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check0_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check1LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check1 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check1_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check2LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check2 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check2_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check3LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check3 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check3_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check4LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check4 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check4_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check5LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check5 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check5_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check6LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check6 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check6_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check7LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check7 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check7_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check8LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check8 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check8_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check9LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check9 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check9_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check10LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check10 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check10_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check11LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check11 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check11_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check12LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check12 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check12_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check13LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check13 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check13_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check14LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check14 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check14_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check15LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check15 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check15_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check16LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check16 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check16_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }

            if (check17LD.Checked.Equals(true) && checkCP.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Valor cobrado somente com o check17 Lado Direito
            {
                MessageBox.Show(av + Math.Round(car.total_check17_ArCondicionado(), 2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Caixa de mensagem com o valor
            }
        }

        private void btnPesquisarAvaria_Click(object sender, EventArgs e)
        {
            PesquisarAV pesav = new PesquisarAV();

            pesav.ShowDialog();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            AvariaAR.ActiveForm.Close();
        }

        private void tsCombNordem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsCombNordem.SelectedItem.Equals("58009") || tsCombNordem.SelectedItem.Equals("58016") || tsCombNordem.SelectedItem.Equals("58017") || tsCombNordem.SelectedItem.Equals("58028") || tsCombNordem.SelectedItem.Equals("58031") || tsCombNordem.SelectedItem.Equals("58058") || tsCombNordem.SelectedItem.Equals("58060")
            || tsCombNordem.SelectedItem.Equals("58081") || tsCombNordem.SelectedItem.Equals("58088") || tsCombNordem.SelectedItem.Equals("58100") || tsCombNordem.SelectedItem.Equals("58103") || tsCombNordem.SelectedItem.Equals("58106") || tsCombNordem.SelectedItem.Equals("58113") || tsCombNordem.SelectedItem.Equals("58114")
            || tsCombNordem.SelectedItem.Equals("58115") || tsCombNordem.SelectedItem.Equals("58116") || tsCombNordem.SelectedItem.Equals("58120") || tsCombNordem.SelectedItem.Equals("58121") || tsCombNordem.SelectedItem.Equals("58125") || tsCombNordem.SelectedItem.Equals("58147") || tsCombNordem.SelectedItem.Equals("58172")
            || tsCombNordem.SelectedItem.Equals("58177") || tsCombNordem.SelectedItem.Equals("58178") || tsCombNordem.SelectedItem.Equals("58185") || tsCombNordem.SelectedItem.Equals("58188") || tsCombNordem.SelectedItem.Equals("58190") || tsCombNordem.SelectedItem.Equals("58204") || tsCombNordem.SelectedItem.Equals("58205")
            || tsCombNordem.SelectedItem.Equals("58207") || tsCombNordem.SelectedItem.Equals("58210") || tsCombNordem.SelectedItem.Equals("58211") || tsCombNordem.SelectedItem.Equals("58214") || tsCombNordem.SelectedItem.Equals("58215") || tsCombNordem.SelectedItem.Equals("58216") || tsCombNordem.SelectedItem.Equals("58217"))
            {
                tsTxtModelo.Text = "Ar condicionado";
            }

            if (tsCombNordem.SelectedItem.Equals("58006") || tsCombNordem.SelectedItem.Equals("58007") || tsCombNordem.SelectedItem.Equals("58008") || tsCombNordem.SelectedItem.Equals("58010") || tsCombNordem.SelectedItem.Equals("58012") || tsCombNordem.SelectedItem.Equals("58013") || tsCombNordem.SelectedItem.Equals("58022")
                || tsCombNordem.SelectedItem.Equals("58024") || tsCombNordem.SelectedItem.Equals("58025") || tsCombNordem.SelectedItem.Equals("58027") || tsCombNordem.SelectedItem.Equals("58032") || tsCombNordem.SelectedItem.Equals("58034") || tsCombNordem.SelectedItem.Equals("58035") || tsCombNordem.SelectedItem.Equals("58039")
                || tsCombNordem.SelectedItem.Equals("58040") || tsCombNordem.SelectedItem.Equals("58043") || tsCombNordem.SelectedItem.Equals("58044") || tsCombNordem.SelectedItem.Equals("58046") || tsCombNordem.SelectedItem.Equals("58047") || tsCombNordem.SelectedItem.Equals("58048") || tsCombNordem.SelectedItem.Equals("58052")
                || tsCombNordem.SelectedItem.Equals("58055") || tsCombNordem.SelectedItem.Equals("58056") || tsCombNordem.SelectedItem.Equals("58059") || tsCombNordem.SelectedItem.Equals("58094") || tsCombNordem.SelectedItem.Equals("58095") || tsCombNordem.SelectedItem.Equals("58096") || tsCombNordem.SelectedItem.Equals("58097")
                || tsCombNordem.SelectedItem.Equals("58105") || tsCombNordem.SelectedItem.Equals("58117") || tsCombNordem.SelectedItem.Equals("58119") || tsCombNordem.SelectedItem.Equals("58123") || tsCombNordem.SelectedItem.Equals("58124") || tsCombNordem.SelectedItem.Equals("58127") || tsCombNordem.SelectedItem.Equals("58128")
                || tsCombNordem.SelectedItem.Equals("58151") || tsCombNordem.SelectedItem.Equals("58167") || tsCombNordem.SelectedItem.Equals("58168") || tsCombNordem.SelectedItem.Equals("58169") || tsCombNordem.SelectedItem.Equals("58171") || tsCombNordem.SelectedItem.Equals("58173") || tsCombNordem.SelectedItem.Equals("58189")) // Modelo de carros 1519
            {
                tsTxtModelo.Text = "1519";
            }

            if (tsCombNordem.SelectedItem.Equals("58001") || tsCombNordem.SelectedItem.Equals("58003") || tsCombNordem.SelectedItem.Equals("58011") || tsCombNordem.SelectedItem.Equals("58014") || tsCombNordem.SelectedItem.Equals("58019") || tsCombNordem.SelectedItem.Equals("58020") || tsCombNordem.SelectedItem.Equals("58023")
                || tsCombNordem.SelectedItem.Equals("58023") || tsCombNordem.SelectedItem.Equals("58033") || tsCombNordem.SelectedItem.Equals("58042") || tsCombNordem.SelectedItem.Equals("58049") || tsCombNordem.SelectedItem.Equals("58053") || tsCombNordem.SelectedItem.Equals("58054") || tsCombNordem.SelectedItem.Equals("58061")
                || tsCombNordem.SelectedItem.Equals("58065") || tsCombNordem.SelectedItem.Equals("58070") || tsCombNordem.SelectedItem.Equals("58073") || tsCombNordem.SelectedItem.Equals("58077") || tsCombNordem.SelectedItem.Equals("58078") || tsCombNordem.SelectedItem.Equals("58079") || tsCombNordem.SelectedItem.Equals("58089")
                || tsCombNordem.SelectedItem.Equals("58091") || tsCombNordem.SelectedItem.Equals("58092") || tsCombNordem.SelectedItem.Equals("58098") || tsCombNordem.SelectedItem.Equals("58102") || tsCombNordem.SelectedItem.Equals("58110") || tsCombNordem.SelectedItem.Equals("58111") || tsCombNordem.SelectedItem.Equals("58118")
                || tsCombNordem.SelectedItem.Equals("58122") || tsCombNordem.SelectedItem.Equals("58131") || tsCombNordem.SelectedItem.Equals("58132") || tsCombNordem.SelectedItem.Equals("58135") || tsCombNordem.SelectedItem.Equals("58150") || tsCombNordem.SelectedItem.Equals("58152") || tsCombNordem.SelectedItem.Equals("58153")
                || tsCombNordem.SelectedItem.Equals("58155") || tsCombNordem.SelectedItem.Equals("58157") || tsCombNordem.SelectedItem.Equals("58160") || tsCombNordem.SelectedItem.Equals("58161") || tsCombNordem.SelectedItem.Equals("58162") || tsCombNordem.SelectedItem.Equals("58163") || tsCombNordem.SelectedItem.Equals("58164")
                || tsCombNordem.SelectedItem.Equals("58165") || tsCombNordem.SelectedItem.Equals("58166") || tsCombNordem.SelectedItem.Equals("58174")) // Modelo de carros 1722
            {
                tsTxtModelo.Text = "1722";
            }
        }

        private void tsTxtModelo_TextChanged(object sender, EventArgs e)
        {
            if (tsTxtModelo.Text.Equals("Ar condicionado"))
            {
                btnCalcularAR.Visible = true; // Ativa a visibilidade do botão calcular do ar condicionado

                btnCalcular1722.Visible = false; // Desativa a visibilidade do botão calcular 1722

                btnCalcular.Visible = false; // Desativa a visibilidade do botão calcular 1519          
            }

            if (tsTxtModelo.Text.Equals("1722"))
            {
                btnCalcularAR.Visible = false; // Desativa a visibilidade do botão calcular do ar condicionado

                btnCalcular1722.Visible = true; // Ativa a visibilidade do botão calcular 1722

                btnCalcular.Visible = false; // Desativa a visibilidade do botão calcular 1519

            }

            if (tsTxtModelo.Text.Equals("1519"))
            {
                btnCalcularAR.Visible = false; // Desativa a visibilidade do botão calcular do ar condicionado

                btnCalcular1722.Visible = false; // Desativa a visibilidade do botão calcular 1722

                btnCalcular.Visible = true; // Ativa a visibilidade do botão calcular 1519

            }

            if (rbTraseira.Checked.Equals(true)) // Se o botão da traseira estiver marcado
            {

                pnlCheckTraseira.Visible = true; // Ativa a visibilidade do painel com os check da traseira                            


                // =================== Lado direito ===================

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado direito
                }

                pnlCheckLD.Visible = false; // Desativa a visibilidade dos Checks do Lado direito

                // =================== Lado Esquerdo ===================

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado Esquerdo
                }

                pnlCheckLE.Visible = false; // Desativa a visiblidade dos check do Lado Esquerdo

                // =================== Dianteira ===================

                foreach (Component Controls in pnlCheckFrente.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da dianteira
                }

                pnlCheckFrente.Visible = false; // Desativa a visiblidade do painel da dianteira com os checks


            }

            if (rbLD.Checked.Equals(true)) // Se o botao lado direito estiver marcado
            {
                pnlCheckLD.Visible = true; // Visibilidade do painel dos Checks ativada                               


                // =================== Lado Esquerdo ===================

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado Esquerdo
                }

                pnlCheckLE.Visible = false; // Desativa o painel com os check do Lado Esquerdo

                // =================== Dianteira ===================

                foreach (Component Controls in pnlCheckFrente.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da dianteira
                }

                pnlCheckFrente.Visible = false; // Desativa a visiblidade do painel da dianteira com os checks

                // =================== Traseira ===================

                foreach (Component Controls in pnlCheckTraseira.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
                }

                pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira


            }


            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado esquerdo estiver marcado e o modelo de carro for ar condicionado quando apertar enter a foto muda para esquerda do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Esquerdo1;

                AvariaAR.ActiveForm.Refresh();

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Visible = true; // Ativa a visibilidade de todas as checkbox do painel
                }
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Esquerdo; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Refresh();

                check18LE.Visible = false; // Desativa o check18 Lado Esquerdo

                check19LE.Visible = false; // Desativa o check19 Lado Esquerdo
            }



            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Esquerdo estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Esquerdo do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Esquerdo; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Refresh();
            }

            if (rbLE.Checked.Equals(true)) // Exibide o lado Esquerdo
            {

                pnlCheckLE.Visible = true; // Ativa a visibilidade do painel com os check Lado Esquerdo

                // =================== Lado direito ===================

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado direito
                }

                pnlCheckLD.Visible = false; // Desativa o painel responsável pela exibição dos checks

                // =================== Dianteira ===================

                foreach (Component Controls in pnlCheckFrente.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da dianteira
                }

                pnlCheckFrente.Visible = false; // Desativa a visiblidade do painel da dianteira com os checks

                // =================== Traseira ===================

                foreach (Component Controls in pnlCheckTraseira.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
                }

                pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira

            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Traseira; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Refresh();
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Frente; //Se a dianteira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Refresh();
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a frente estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para frente do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Frente1;

                AvariaAR.ActiveForm.Refresh();
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a frente estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para frente do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Frente; // Se a frente estiver marcada e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Refresh();
            }


            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a traseira estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para traseira do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Traseira1;

                AvariaAR.ActiveForm.Refresh();

            }


            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a traseira estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para traseira do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Traseira; // Se a traseira estiver marcada e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Refresh();
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado direito estiver marcado e o modelo de carro for ar condicionado quando apertar enter a foto muda para direita do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Direito1;

                AvariaAR.ActiveForm.Refresh();

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Visible = true;
                }
            }

            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Direito estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Direito do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Direito; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Refresh();

                check15LD.Visible = false; // Desativa a visiblidade do check15

                check16LD.Visible = false; // Desativa a visiblidade do check16

                check17LD.Visible = false; // Desativa a visiblidade do check17
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Direito; //Se o lado Direito estiver marcado e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Refresh();

                check15LD.Visible = true; // Ativa a visiblidade do check15

                check16LD.Visible = false; // Desativa o check16 Lado Direito

                check17LD.Visible = false; // Desativa o check17 Lado Direito
            }


            if (rbDianteira.Checked.Equals(true)) // Se o botao da dianteira estiver marcado
            {

                pnlCheckFrente.Visible = true;


                pnlCheckTraseira.Visible = false; // Desativa a visibilidade com os check da traseira


                pnlCheckLD.Visible = false; // Desativa a visibilidade dos Checks do Lado direito

                pnlCheckLE.Visible = false; // Desativa a visibilidade do painel com os check do Lado Esquerdo


                // =================== Lado direito ===================

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado direito
                }

                // =================== Lado Esquerdo ===================

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox do Lado Esquerdo
                }

                // =================== Traseira ===================

                foreach (Component Controls in pnlCheckTraseira.Controls)
                {
                    (Controls as CheckBox).Checked = false; // Desmarca todos os checkbox da traseira
                }


            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPesquisas pesquisas = new frmPesquisas();

            pesquisas.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = true;

            pnlProdutos.Dock = DockStyle.Fill;            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = false;            
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vnslourdesDataSet);

        }

        private void produtosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vnslourdesDataSet);

        }

        private void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vnslourdesDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = false;
        }

        private void checkCP_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkCP.Checked.Equals(true)) // Se o check Carroceria Pintura estiver marcado o check de Pintura fica desabilitado
            {
                checkP.Enabled = false; // Desativa o check de pintura
            }

            else
            {
                checkP.Enabled = true; // Senão o check de pintura fica habilitado 
            }
        }

        private void checkP_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkP.Checked.Equals(true)) // Quando o tipo de avaria PINTURA estiver marcado o tipo de avaria carroceria e pintura ficar desabilitado
            {
                checkCP.Enabled = false; // Desativa o check Carroceria e pintura

            }

            else
            {
                checkCP.Enabled = true; // Senão o check de carroceria pintura fica habilitado 
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(P.chapa90.ToString());
            
        }

        private void AvariaAR_Activated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + Math.Round(c1722.total_check1_1722(), 2));
        }
    }
}

       