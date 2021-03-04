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

        public void Modelo_1519LD()
        {
            check15LD.Visible = true; // Ativa a visiblidade do check15

            check16LD.Visible = false; // Desativa o check16 Lado Direito

            check17LD.Visible = false; // Desativa o check17 Lado Direito
        }

        public void Modelo_1519LE()
        {
            check18LE.Visible = false; // Desativa o check18 Lado Esquerdo

            check19LE.Visible = false; // Desativa o check19 Lado Esquerdo
        }

        public void Modelo_1722LD()
        {
            check15LD.Visible = false; // Desativa a visiblidade do check15

            check16LD.Visible = false; // Desativa a visiblidade do check16

            check17LD.Visible = false; // Desativa a visiblidade do check17
        }

        public void Selected_Traseira()
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

            AvariaAR.ActiveForm.Update();
        }

        public void Selecionado_Lado_Direito()
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

            AvariaAR.ActiveForm.Update();
        }

        public void Selecionado_Lado_Esquerdo()
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

            AvariaAR.ActiveForm.Update();
        }

        public void Selecionado_Dianteira()
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

            AvariaAR.ActiveForm.Update();

        }


        private void AvariaAR_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.vnslourdesDataSet.produtos);
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.vnslourdesDataSet.produtos);
                      
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

                btnCalcular1519.Visible = false; // Desativa a visibilidade do botão calcular 1519          
            }

            if (tsTxtModelo.Text.Equals("1722"))
            {
                btnCalcularAR.Visible = false; // Desativa a visibilidade do botão calcular do ar condicionado

                btnCalcular1722.Visible = true; // Ativa a visibilidade do botão calcular 1722

                btnCalcular1519.Visible = false; // Desativa a visibilidade do botão calcular 1519

            }

            if (tsTxtModelo.Text.Equals("1519"))
            {
                btnCalcularAR.Visible = false; // Desativa a visibilidade do botão calcular do ar condicionado

                btnCalcular1722.Visible = false; // Desativa a visibilidade do botão calcular 1722

                btnCalcular1519.Visible = true; // Ativa a visibilidade do botão calcular 1519

            }

            if (rbTraseira.Checked.Equals(true)) // Se o botão da traseira estiver marcado
            {
                Selected_Traseira();                
            }

            if (rbLD.Checked.Equals(true)) // Se o botao lado direito estiver marcado
            {
                Selecionado_Lado_Direito();
            }


            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado esquerdo estiver marcado e o modelo de carro for ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Esquerdo1;

                AvariaAR.ActiveForm.Update();

                foreach (Component Controls in pnlCheckLE.Controls)
                {
                    (Controls as CheckBox).Visible = true; // Ativa a visibilidade de todas as checkbox do painel
                }
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Esquerdo; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Update();

                Modelo_1519LE();
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Esquerdo estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Esquerdo do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Esquerdo; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Update();
            }

            if (rbLE.Checked.Equals(true)) // Exibide o lado Esquerdo
            {
                Selecionado_Lado_Esquerdo();
            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Traseira; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Update();                                
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {

                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Frente; //Se a dianteira estiver macada e o modelo for 1519 a foto muda para 1519

                AvariaAR.ActiveForm.Update();
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a frente estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para frente do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Frente1;

                AvariaAR.ActiveForm.Update();
            }


            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a frente estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para frente do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Frente; // Se a frente estiver marcada e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Update();
            }


            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a traseira estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para traseira do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Traseira1;

                AvariaAR.ActiveForm.Update();

            }


            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a traseira estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para traseira do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Traseira; // Se a traseira estiver marcada e o modelo for 1722 altera a imagem

                AvariaAR.ActiveForm.Update();
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado direito estiver marcado e o modelo de carro for ar condicionado quando apertar enter a foto muda para direita do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Direito1;

                AvariaAR.ActiveForm.Update();

                foreach (Component Controls in pnlCheckLD.Controls)
                {
                    (Controls as CheckBox).Visible = true;
                }
            }

            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Direito estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Direito do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Direito; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                Modelo_1722LD();

                AvariaAR.ActiveForm.Update();
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Direito; //Se o lado Direito estiver marcado e o modelo for 1519 a foto muda para 1519

                Modelo_1519LD();
               
                AvariaAR.ActiveForm.Update();
            }


            if (rbDianteira.Checked.Equals(true)) // Se o botao da dianteira estiver marcado
            {
                Selecionado_Dianteira();
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

        private void btnTeste_Click(object sender, EventArgs e)
        {
                        
        }

        private void rbLD_CheckedChanged(object sender, EventArgs e) // Radio Button Lado Direito
        {            
            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o Lado Direito estiver marcado e o modelo do carro for 1722 quando apertar enter muda a foto para Lado Direito do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Direito; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                Selecionado_Lado_Direito();

                Modelo_1722LD();
            }

            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Direito; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                Selecionado_Lado_Direito();
            }


            if (rbLD.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o lado direito estiver marcado e o modelo de carro for ar condicionado quando apertar enter a foto muda para direita do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Direito1;

                Selecionado_Lado_Direito();
            }

            Selecionado_Lado_Direito();
        }

        private void rbLE_CheckedChanged(object sender, EventArgs e) // Radio Button Lado Esquerdo
        {
            
            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se o número de ordem for modelo 1722 e o lado esquerdo estiver selecionado altera a imagem para 1722
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Lado_Esquerdo; // Se o Lado Direito estiver marcado e o modelo for 1722 altera a imagem

                Selecionado_Lado_Esquerdo();
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se o número de ordem for modelo Ar condicionado e o lado esquerdo estiver selecionado altera a imagem para Ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Lado_Esquerdo1; // Esquerda Sem número

                Selecionado_Lado_Esquerdo();
            }

            if (rbLE.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Lado_Esquerdo; // Esquerda Sem número

                Selecionado_Lado_Esquerdo();
            }


            Selecionado_Lado_Esquerdo();
        }

        private void rbDianteira_CheckedChanged(object sender, EventArgs e) // Radio Button Dianteira
        {
            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a frente estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para frente do ar condicionado
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Frente1; // Frente ar condiconado sem numero

                Selecionado_Dianteira();
            }

            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a frente estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para frente do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Frente; // Se a frente estiver marcada e o modelo for 1722 altera a imagem

                Selecionado_Dianteira();
            }

            if (rbDianteira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Frente; // Se a dianteira estiver marcada e o modelo for 1519 a foto muda para 1519

                Selecionado_Dianteira();
            }

            Selecionado_Dianteira();
        }

        private void rbTraseira_CheckedChanged(object sender, EventArgs e)
        {            
            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1722")) // Se a traseira estiver marcada e o modelo do carro for 1722 quando apertar enter muda a foto para traseira do 1722 
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722_Traseira; // Se a traseira estiver marcada e o modelo for 1722 altera a imagem

                Selected_Traseira();
            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("Ar condicionado")) // Se a traseira estiver marcada e o modelo de carro for ar condicionado quando apertar enter a foto muda para traseira do ar condicionado)
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado_Traseira1; // Se o a traseira estiver marcada e o modelo for Ar condicionado altera a imagem

                Selected_Traseira();
            }

            if (rbTraseira.Checked.Equals(true) && tsTxtModelo.Text.Equals("1519"))
            {
                AvariaAR.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes_Traseira; //Se a traseira estiver macada e o modelo for 1519 a foto muda para 1519

                Selected_Traseira();
            }

            Selected_Traseira();
        }
    }
}

       