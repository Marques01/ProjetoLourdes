using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql;
using MySqlX;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Empresa2
{

    public partial class manutencao : Form
    {
        int id = 1;
        
        MySqlCommand Sql = new MySqlCommand();

        public manutencao()
        {
            InitializeComponent();
        }


        private void ModeloAR()
        {
            foreach (Component Controls in pnlDianteira.Controls)
            {
                (Controls as Label).Visible = true; // Ativa a visibilidade de todos os números
            }

            foreach (Component Controls in pnlLDAR.Controls)
            {
                (Controls as Label).Visible = true; // Ativa a visibilidade de todos os números
            }

            foreach (Component Controls in pnlLEAR.Controls)
            {
                (Controls as Label).Visible = true; // Ativa a visibilidade de todos os números
            }

            foreach (Component Controls in pnlTraseira.Controls)
            {
                (Controls as Label).Visible = true; // Ativa a visibilidade de todos os números
            }

            // Lado Direito

            pnlLDAR.Location = new Point(5, 5);

            pnlDianteira.Visible = true;

            pnlTraseira.Visible = true;

            pnlLEAR.Visible = true;

            pnlLDAR.Visible = true;

            lblColunaTDAR.Location = new Point(12, 128);

            lblChapa1AR.Location = new Point(59, 128);

            lblChapa2AR.Location = new Point(132, 128);

            lblChapa3AR.Location = new Point(220, 128);

            lblChapa4AR.Location = new Point(303, 128);

            lblChapa5AR.Location = new Point(520, 128);

            lblChapa6AR.Location = new Point(577, 128);

            lblChapa7AR.Location = new Point(59, 175);

            lblChapa8AR.Location = new Point(132, 179);

            lblChapa9AR.Location = new Point(189, 166);

            lblChapa10AR.Location = new Point(303, 179);

            lblChapa11AR.Location = new Point(383, 179);

            lblChapa12AR.Location = new Point(432, 179);

            lblChapa13AR.Location = new Point(462, 179);

            lblChapa14AR.Location = new Point(513, 179);

            lblChapa15AR.Location = new Point(552, 164);

            lblChapa16AR.Location = new Point(636, 149);

            lblChapa17AR.Location = new Point(725, 179);

            lblBicoColunaTD.Location = new Point(3, 13);

            lblBicoColunaTD.Text = "18";

            lblFlexalLD.Location = new Point(328, 10);

            lblFlexalLD.Text = "19";

            lblBicoColunaDD.Location = new Point(726, 17);

            lblBicoColunaDD.Text = "20";

            // Lado Esquerdo

            pnlLEAR.Location = new Point(4, 247);

            lblChapa1LEAR.Location = new Point(56, 145);

            lblChapa2LEAR.Location = new Point(144, 130);

            lblChapa3LEAR.Location = new Point(251, 130);

            lblChapa4LEAR.Location = new Point(353, 130);

            lblChapa5LEAR.Location = new Point(445, 130);

            lblChapa6LEAR.Location = new Point(521, 130);

            lblChapa7LEAR.Location = new Point(612, 130);

            lblChapa8LEAR.Location = new Point(689, 130);

            lblChapa9LEAR.Location = new Point(46, 181);

            lblChapa10LEAR.Location = new Point(81, 181);

            lblChapa11LEAR.Location = new Point(194, 181);

            lblChapa12LEAR.Location = new Point(230, 181);

            lblChapa13LEAR.Location = new Point(282, 181);

            lblChapa14LEAR.Location = new Point(341, 181);

            lblChapa15LEAR.Location = new Point(451, 181);

            lblChapa16LEAR.Location = new Point(553, 161);

            lblChapa17LEAR.Location = new Point(612, 181);

            lblChapa18LEAR.Location = new Point(689, 179);

            lblColunaTEAR.Location = new Point(726, 175);


            lblBicoColunaDE.Location = new Point(15, 14);

            lblBicoColunaTE.Text = "20";


            lblFlexalLE.Location = new Point(490, 16);
            lblFlexalLE.Text = "21";


            lblBicoColunaTE.Location = new Point(735, 16);

            lblBicoColunaTE.Text = "22";




            // Traseira

            lblColunaTE1.Location = new Point(12, 70);

            lblTraseiraM.Location = new Point(95, 102);

            lblColunaTD2.Location = new Point(171, 70);

            lblPonteiraTE.Location = new Point(15, 164);

            lblParachoqueT.Location = new Point(95, 164);

            lblPonteiraTD.Location = new Point(168, 164);

            // Dianteira 

            lblGradeAR.Location = new Point(91, 13);

            lblPonteiraDEAR.Location = new Point(16, 40);

            lblParachoqueDAR.Location = new Point(91, 37);

            lblPonteiraDDAR.Location = new Point(165, 41);

        }

        private void Modelo1722()
        {
            pnlLDAR.Location = new Point(5, 5);
            
            pnlDianteira.Visible = true;

            pnlTraseira.Visible = true;

            pnlLEAR.Visible = true;

            pnlLDAR.Visible = true;

            lblColunaTDAR.Location = new Point(7, 118);

            lblChapa1AR.Location = new Point(59, 118);

            lblChapa2AR.Location = new Point(241, 118);

            lblChapa3AR.Location = new Point(340, 118);

            lblChapa4AR.Location = new Point(444, 118);

            lblChapa5AR.Location = new Point(532, 118);

            lblChapa6AR.Location = new Point(636, 118);

            lblChapa7AR.Location = new Point(59, 175);

            lblChapa8AR.Location = new Point(121, 174);

            lblChapa9AR.Location = new Point(165, 175);

            lblChapa10AR.Location = new Point(189, 151);

            lblChapa11AR.Location = new Point(328, 174);

            lblChapa12AR.Location = new Point(432, 174);

            lblChapa13AR.Location = new Point(523, 174);

            lblChapa14AR.Location = new Point(658, 174);

            lblChapa15AR.Visible = false;

            lblChapa16AR.Visible = false;

            lblChapa17AR.Visible = false;

            lblBicoColunaTD.Location = new Point(-1, 4);

            lblBicoColunaTD.Text = "15";

            lblFlexalLD.Location = new Point(309, 3);

            lblFlexalLD.Text = "16";

            lblBicoColunaDD.Location = new Point(738, 1);

            lblBicoColunaDD.Text = "17";


            // Lado Esquerdo

            pnlLEAR.Location = new Point(4, 247);

            lblColunaTEAR.Location = new Point(738, 172);

            lblChapa1LEAR.Location = new Point(59, 137);

            lblChapa2LEAR.Location = new Point(143, 123);

            lblChapa3LEAR.Location = new Point(230, 123);

            lblChapa4LEAR.Location = new Point(329, 123);

            lblChapa5LEAR.Location = new Point(427, 123);

            lblChapa6LEAR.Location = new Point(524, 123);

            lblChapa7LEAR.Location = new Point(612, 123);

            lblChapa8LEAR.Location = new Point(689, 123);

            lblChapa9LEAR.Location = new Point(43, 176);

            lblChapa10LEAR.Location = new Point(76, 176);

            lblChapa11LEAR.Location = new Point(194, 181);

            lblChapa12LEAR.Location = new Point(230, 181);

            lblChapa13LEAR.Location = new Point(282, 181);

            lblChapa14LEAR.Location = new Point(341, 181);

            lblChapa15LEAR.Location = new Point(451, 181);

            lblChapa16LEAR.Location = new Point(555, 181);

            lblChapa17LEAR.Location = new Point(612, 181);

            lblChapa17LEAR.Visible = true;

            lblChapa18LEAR.Location = new Point(689, 175);

            lblChapa18LEAR.Visible = true;


            lblBicoColunaDE.Location = new Point(8, 10);

            lblBicoColunaDE.Text = "20";

            lblFlexalLE.Location = new Point(484, 7);

            lblFlexalLE.Text = "21";

            lblBicoColunaTE.Location = new Point(744, 7);

            lblBicoColunaTE.Text = "22";

            // Traseira 

            lblColunaTE1.Location = new Point(12, 70);

            lblTraseiraM.Location = new Point(88, 96);

            lblColunaTD2.Location = new Point(160, 70);

            lblPonteiraTE.Location = new Point(14, 156);

            lblParachoqueT.Location = new Point(88, 164);

            lblPonteiraTD.Location = new Point(160, 159);

            // Dianteira 

            lblGradeAR.Location = new Point(85, 2);

            lblPonteiraDEAR.Location = new Point(13, 32);

            lblParachoqueDAR.Location = new Point(85, 22);

            lblPonteiraDDAR.Location = new Point(155, 32);

        }

        private void Modelo1519()
        {
            pnlLDAR.Location = new Point(5, 5);

            pnlDianteira.Visible = true;

            pnlTraseira.Visible = true;

            pnlLEAR.Visible = true;

            pnlLDAR.Visible = true;

            lblColunaTDAR.Location = new Point(11, 138);

            lblChapa1AR.Location = new Point(75, 138);

            lblChapa2AR.Location = new Point(175, 138);

            lblChapa3AR.Location = new Point(270, 138);

            lblChapa4AR.Location = new Point(462, 138);

            lblChapa5AR.Location = new Point(566, 138);

            lblChapa6AR.Location = new Point(76, 188);

            lblChapa7AR.Location = new Point(175, 188);

            lblChapa8AR.Location = new Point(306, 188);

            lblChapa9AR.Location = new Point(345, 188);

            lblChapa10AR.Location = new Point(382, 188);

            lblChapa11AR.Location = new Point(438, 188);

            lblChapa12AR.Location = new Point(502, 188);

            lblChapa13AR.Location = new Point(545, 170);

            lblChapa14AR.Location = new Point(639, 170);

            lblChapa15AR.Location = new Point(726, 187);

            lblChapa15AR.Visible = true;

            lblBicoColunaTD.Location = new Point(1, 13);

            lblBicoColunaTD.Text = "16";

            lblFlexalLD.Location = new Point(308, 13);

            lblFlexalLD.Text = "17";

            lblBicoColunaDD.Location = new Point(733, 14);

            lblBicoColunaDD.Text = "18";

            lblChapa16AR.Visible = false;

            lblChapa17AR.Visible = false;

            // Lado esquerdo

            pnlLEAR.Location = new Point(4, 247);

            lblChapa1LEAR.Location = new Point(76, 162);

            lblChapa2LEAR.Location = new Point(162, 162);

            lblChapa3LEAR.Location = new Point(248, 162);

            lblChapa4LEAR.Location = new Point(347, 162);

            lblChapa5LEAR.Location = new Point(451, 162);

            lblChapa6LEAR.Location = new Point(558, 162);

            lblChapa7LEAR.Location = new Point(667, 162);

            lblChapa8LEAR.Location = new Point(52, 209);

            lblChapa9LEAR.Location = new Point(98, 209);

            lblChapa10LEAR.Location = new Point(194, 209);

            lblChapa11LEAR.Location = new Point(236, 209);

            lblChapa12LEAR.Location = new Point(290, 209);

            lblChapa13LEAR.Location = new Point(368, 209);

            lblChapa14LEAR.Location = new Point(451, 209);

            lblChapa15LEAR.Location = new Point(567, 209);

            lblChapa16LEAR.Location = new Point(640, 209);

            lblChapa17LEAR.Location = new Point(728, 209); // Coluna TE

            lblChapa18LEAR.Visible = false;

            lblColunaTEAR.Visible = false;

            lblBicoColunaDE.Location = new Point(7, 38);

            lblBicoColunaDE.Text = "18";

            lblFlexalLE.Location = new Point(480, 34);

            lblFlexalLE.Text = "19";

            lblBicoColunaTE.Location = new Point(738, 34);

            lblBicoColunaTE.Text = "20";

            // Dianteira

            lblGradeAR.Location = new Point(85, 20);

            lblPonteiraDEAR.Location = new Point(13, 54);

            lblParachoqueDAR.Location = new Point(85, 44);

            lblPonteiraDDAR.Location = new Point(155, 54);

            // Traseira

            lblColunaTE1.Location = new Point(11, 106);

            lblTraseiraM.Location = new Point(88, 131);

            lblColunaTD2.Location = new Point(165, 106);

            lblPonteiraTE.Location = new Point(11, 192);

            lblParachoqueT.Location = new Point(86, 198);

            lblPonteiraTD.Location = new Point(164, 192);

        }

        private void limpar()
        {
            txtAvariaA.Clear();

            foreach (Component Controls in pnlLDAR.Controls)
            {
                (Controls as Label).ForeColor = Color.Black;
            }

        }

        private void limparLEAR()
        {
            foreach (Component Controls in pnlLEAR.Controls)
            {
                (Controls as Label).ForeColor = Color.Black;
            }

            txtAvariaA.Clear();
        }

        private void LimparDianteira()
        {
            foreach (Component Controls in pnlDianteira.Controls)
            {
                (Controls as Label).ForeColor = Color.Black;

                txtAvariaA.Clear();
            }
        }

        private void LimparTraseira()
        {
            foreach (Component Controls in pnlTraseira.Controls)
            {
                (Controls as Label).ForeColor = Color.Black;

                txtAvariaA.Clear();
            }
        }

        private void Anotador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.gravar_avaria'. Você pode movê-la ou removê-la conforme necessário.
            this.gravar_avariaTableAdapter.Fill(this.vnslourdesDataSet.gravar_avaria);
            pnlDianteira.Visible = false;

            pnlTraseira.Visible = false;

            pnlLDAR.Visible = false;

            pnlLEAR.Visible = false;

            txtData.Enabled = false;

            txtAvariaA.Clear();

            combNordem.SelectedItem.Equals("");

            txtModelo.Clear();

            txtData.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");

            toolTip1.SetToolTip(picAjudaAvaria, "Digite a avaria\n\rExemplo: Chapa 1 Lado Direito e Chapa 3 Lado Esquerdo\n\rUse os botões para mudar o lado do veículo");
                        
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

        }

        private void picAjudaAvaria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a avaria\n\rExemplo: Chapa 1 Lado Direito e Chapa 3 Lado Esquerdo\n\rUse os botões para mudar o lado do veículo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }      

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (lblChapa1AR.ForeColor.Equals(Color.Black))
            {
                lblChapa1AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 1 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa2AR_Click(object sender, EventArgs e)
        {
            if (lblChapa2AR.ForeColor.Equals(Color.Black))
            {
                lblChapa2AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 2 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa3AR_Click(object sender, EventArgs e)
        {
            if (lblChapa3AR.ForeColor.Equals(Color.Black))
            {
                lblChapa3AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 3 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa4AR_Click(object sender, EventArgs e)
        {
            if (lblChapa4AR.ForeColor.Equals(Color.Black))
            {
                lblChapa4AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 4 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa5AR_Click(object sender, EventArgs e)
        {
            if (lblChapa5AR.ForeColor.Equals(Color.Black))
            {
                lblChapa5AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 5 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa6AR_Click(object sender, EventArgs e)
        {
            if (lblChapa6AR.ForeColor.Equals(Color.Black))
            {
                lblChapa6AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 6 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa7AR_Click(object sender, EventArgs e)
        {
            if (lblChapa7AR.ForeColor.Equals(Color.Black))
            {
                lblChapa7AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 7 Lado Direito");
            }

            else
            {
                limpar();
            }


        }


        private void lblChapa8AR_Click(object sender, EventArgs e)
        {
            if (lblChapa8AR.ForeColor.Equals(Color.Black))
            {
                lblChapa8AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 8 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa9AR_Click(object sender, EventArgs e)
        {
            if (lblChapa9AR.ForeColor.Equals(Color.Black))
            {
                lblChapa9AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 9 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa10AR_Click(object sender, EventArgs e)
        {
            if (lblChapa10AR.ForeColor.Equals(Color.Black))
            {
                lblChapa10AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 10 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa11AR_Click(object sender, EventArgs e)
        {
            if (lblChapa11AR.ForeColor.Equals(Color.Black))
            {
                lblChapa11AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 11 Lado Direito");
            }

            else
            {
                limpar();
            }
        }

        private void lblChapa12AR_Click(object sender, EventArgs e)
        {
            if (lblChapa12AR.ForeColor.Equals(Color.Black))
            {
                lblChapa12AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 12 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa13AR_Click(object sender, EventArgs e)
        {
            if (lblChapa13AR.ForeColor.Equals(Color.Black))
            {
                lblChapa13AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 13 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa14AR_Click(object sender, EventArgs e)
        {
            if (lblChapa14AR.ForeColor.Equals(Color.Black))
            {
                lblChapa14AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 14 Lado Direito");
            }

            else
            {
                limpar();

            }
        }

        private void lblChapa15AR_Click(object sender, EventArgs e)
        {
            if (lblChapa15AR.ForeColor.Equals(Color.Black))
            {
                lblChapa15AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 15 Lado Direito");
            }

            else
            {
                limpar();
            }
        }

        private void lblChapa16AR_Click(object sender, EventArgs e)
        {
            if (lblChapa16AR.ForeColor.Equals(Color.Black))
            {
                lblChapa16AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 16 Lado Direito");
            }

            else
            {
                limpar();
            }
        }

        private void lblChapa17AR_Click(object sender, EventArgs e)
        {
            if (lblChapa17AR.ForeColor.Equals(Color.Black))
            {
                lblChapa17AR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 17 Lado Direito");
            }

            else
            {
                limpar();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (lblColunaTDAR.ForeColor.Equals(Color.Black))
            {
                lblColunaTDAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nColuna T/D");
            }

            else
            {
                limpar();
            }
        }

        private void lblChapa1LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa1LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa1LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 1 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa2LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa2LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa2LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 2 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa3LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa3LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa3LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 3 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa4LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa4LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa4LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 4 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa5LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa5LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa5LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 5 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa6LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa6LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa6LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 6 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa7LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa7LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa7LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 7 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa8LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa8LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa8LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 8 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa9LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa9LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa9LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 9 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa10LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa10LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa10LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 10 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa11LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa11LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa11LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 11 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa12LE_Click(object sender, EventArgs e)
        {
            if (lblChapa12LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa12LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 12 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa13LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa13LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa13LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 13 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa14LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa14LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa14LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 14 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa15LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa15LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa15LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 15 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa16LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa16LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa16LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 16 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa17LE_Click(object sender, EventArgs e)
        {
            if (lblChapa17LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa17LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 17 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblChapa18LEAR_Click(object sender, EventArgs e)
        {
            if (lblChapa18LEAR.ForeColor.Equals(Color.Black))
            {
                lblChapa18LEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nChapa 18 Lado Esquerdo");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblColunaTEAR_Click(object sender, EventArgs e)
        {
            if (lblColunaTEAR.ForeColor.Equals(Color.Black))
            {
                lblColunaTEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nColuna Traseira Esquerda");
            }

            else
            {
                limparLEAR();
            }
        }

        private void lblGradeAR_Click(object sender, EventArgs e)
        {
            if (lblGradeAR.ForeColor.Equals(Color.Black))
            {
                lblGradeAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nGrade Dianteira");
            }

            else
            {
                LimparDianteira();
            }
        }

        private void lblPonteiraDEAR_Click(object sender, EventArgs e)
        {
            if (lblPonteiraDEAR.ForeColor.Equals(Color.Black))
            {
                lblPonteiraDEAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nPonteira D/E");
            }

            else
            {
                LimparDianteira();
            }


        }

        private void lblParachoqueDAR_Click(object sender, EventArgs e)
        {
            if (lblParachoqueDAR.ForeColor.Equals(Color.Black))
            {
                lblParachoqueDAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nParachoque Dianteiro");
            }

            else
            {
                LimparDianteira();
            }
        }

        private void lblPonteiraDDAR_Click(object sender, EventArgs e)
        {
            if (lblPonteiraDDAR.ForeColor.Equals(Color.Black))
            {
                lblPonteiraDDAR.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nPonteira D/D");
            }

            else
            {
                LimparDianteira();
            }
        }

        private void lblColunaTE1_Click(object sender, EventArgs e)
        {
            if (lblColunaTE1.ForeColor.Equals(Color.Black))
            {
                lblColunaTE1.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nColuna T/E/1");
            }

            else
            {
                LimparTraseira();
            }
        }

        private void lblTraseiraM_Click(object sender, EventArgs e)
        {
            if (lblTraseiraM.ForeColor.Equals(Color.Black))
            {
                lblTraseiraM.ForeColor = Color.Red;

                txtAvariaA.Text += (" \n Traseira(2)");
            }

            else
            {
                LimparTraseira();
            }


        }

        private void lblColunaTD2_Click(object sender, EventArgs e)
        {
            if (lblColunaTD2.ForeColor.Equals(Color.Black))
            {
                lblColunaTD2.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nColuna T/D(2)");
            }

            else
            {
                LimparTraseira();
            }

        }

        private void lblPonteiraTE_Click(object sender, EventArgs e)
        {
            if (lblPonteiraTE.ForeColor.Equals(Color.Black))
            {
                lblPonteiraTE.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nPonteira T/E");
            }

            else
            {
                LimparTraseira();
            }
        }

        private void lblParachoqueT_Click(object sender, EventArgs e)
        {
            if (lblParachoqueT.ForeColor.Equals(Color.Black))
            {
                lblParachoqueT.ForeColor = Color.Red;

                txtAvariaA.Text += ("\nPara choque traseiro");
            }

            else
            {
                LimparTraseira();
            }
        }

        private void lblPonteiraTD_Click(object sender, EventArgs e)
        {
            if (lblPonteiraTD.ForeColor.Equals(Color.Black))
            {
                lblPonteiraTD.ForeColor = Color.Red;

                txtAvariaA.Text += (" \nPonteira T/E");
            }

            else
            {
                LimparTraseira();
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtModelo.Text.Equals(String.Empty) && txtAvariaA.Text != String.Empty)
            {
                MessageBox.Show("Você não informou o número do veículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (txtModelo.Text.Equals(String.Empty) && txtAvariaA.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não informou o número do veículo e o tipo de avaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (txtModelo.Text.Equals(String.Empty) && txtAvariaA.Text.Equals(String.Empty))
            {

                MessageBox.Show("Você não digitou a avaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (txtAvariaA.Text.Equals(String.Empty) && txtModelo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não digitou a avaria e o tipo de avaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (combNordem.SelectedItem.Equals("58001") || combNordem.SelectedItem.Equals("58003") || combNordem.SelectedItem.Equals("58011") || combNordem.SelectedItem.Equals("58014") || combNordem.SelectedItem.Equals("58019") || combNordem.SelectedItem.Equals("58020") || combNordem.SelectedItem.Equals("58023")
               || combNordem.SelectedItem.Equals("58023") || combNordem.SelectedItem.Equals("58033") || combNordem.SelectedItem.Equals("58042") || combNordem.SelectedItem.Equals("58049") || combNordem.SelectedItem.Equals("58053") || combNordem.SelectedItem.Equals("58054") || combNordem.SelectedItem.Equals("58061")
               || combNordem.SelectedItem.Equals("58065") || combNordem.SelectedItem.Equals("58070") || combNordem.SelectedItem.Equals("58073") || combNordem.SelectedItem.Equals("58077") || combNordem.SelectedItem.Equals("58078") || combNordem.SelectedItem.Equals("58079") || combNordem.SelectedItem.Equals("58089")
               || combNordem.SelectedItem.Equals("58091") || combNordem.SelectedItem.Equals("58092") || combNordem.SelectedItem.Equals("58098") || combNordem.SelectedItem.Equals("58102") || combNordem.SelectedItem.Equals("58110") || combNordem.SelectedItem.Equals("58111") || combNordem.SelectedItem.Equals("58118")
               || combNordem.SelectedItem.Equals("58122") || combNordem.SelectedItem.Equals("58131") || combNordem.SelectedItem.Equals("58132") || combNordem.SelectedItem.Equals("58135") || combNordem.SelectedItem.Equals("58150") || combNordem.SelectedItem.Equals("58152") || combNordem.SelectedItem.Equals("58153")
               || combNordem.SelectedItem.Equals("58155") || combNordem.SelectedItem.Equals("58157") || combNordem.SelectedItem.Equals("58160") || combNordem.SelectedItem.Equals("58161") || combNordem.SelectedItem.Equals("58162") || combNordem.SelectedItem.Equals("58163") || combNordem.SelectedItem.Equals("58164")
               || combNordem.SelectedItem.Equals("58165") || combNordem.SelectedItem.Equals("58166") || combNordem.SelectedItem.Equals("58174") || combNordem.SelectedItem.Equals("58009") || combNordem.SelectedItem.Equals("58016") || combNordem.SelectedItem.Equals("58017") || combNordem.SelectedItem.Equals("58028") || combNordem.SelectedItem.Equals("58031") || combNordem.SelectedItem.Equals("58058") || combNordem.SelectedItem.Equals("58060")
            || combNordem.SelectedItem.Equals("58081") || combNordem.SelectedItem.Equals("58088") || combNordem.SelectedItem.Equals("58100") || combNordem.SelectedItem.Equals("58103") || combNordem.SelectedItem.Equals("58106") || combNordem.SelectedItem.Equals("58113") || combNordem.SelectedItem.Equals("58114")
            || combNordem.SelectedItem.Equals("58115") || combNordem.SelectedItem.Equals("58116") || combNordem.SelectedItem.Equals("58120") || combNordem.SelectedItem.Equals("58121") || combNordem.SelectedItem.Equals("58125") || combNordem.SelectedItem.Equals("58147") || combNordem.SelectedItem.Equals("58172")
            || combNordem.SelectedItem.Equals("58177") || combNordem.SelectedItem.Equals("58178") || combNordem.SelectedItem.Equals("58185") || combNordem.SelectedItem.Equals("58188") || combNordem.SelectedItem.Equals("58190") || combNordem.SelectedItem.Equals("58204") || combNordem.SelectedItem.Equals("58205")
            || combNordem.SelectedItem.Equals("58207") || combNordem.SelectedItem.Equals("58210") || combNordem.SelectedItem.Equals("58211") || combNordem.SelectedItem.Equals("58214") || combNordem.SelectedItem.Equals("58215") || combNordem.SelectedItem.Equals("58216") || combNordem.SelectedItem.Equals("58217") ||
            combNordem.SelectedItem.Equals("58006") || combNordem.SelectedItem.Equals("58007") || combNordem.SelectedItem.Equals("58008") || combNordem.SelectedItem.Equals("58010") || combNordem.SelectedItem.Equals("58012") || combNordem.SelectedItem.Equals("58013") || combNordem.SelectedItem.Equals("58022")
                || combNordem.SelectedItem.Equals("58024") || combNordem.SelectedItem.Equals("58025") || combNordem.SelectedItem.Equals("58027") || combNordem.SelectedItem.Equals("58032") || combNordem.SelectedItem.Equals("58034") || combNordem.SelectedItem.Equals("58035") || combNordem.SelectedItem.Equals("58039")
                || combNordem.SelectedItem.Equals("58040") || combNordem.SelectedItem.Equals("58043") || combNordem.SelectedItem.Equals("58044") || combNordem.SelectedItem.Equals("58046") || combNordem.SelectedItem.Equals("58047") || combNordem.SelectedItem.Equals("58048") || combNordem.SelectedItem.Equals("58052")
                || combNordem.SelectedItem.Equals("58055") || combNordem.SelectedItem.Equals("58056") || combNordem.SelectedItem.Equals("58059") || combNordem.SelectedItem.Equals("58094") || combNordem.SelectedItem.Equals("58095") || combNordem.SelectedItem.Equals("58096") || combNordem.SelectedItem.Equals("58097")
                || combNordem.SelectedItem.Equals("58105") || combNordem.SelectedItem.Equals("58117") || combNordem.SelectedItem.Equals("58119") || combNordem.SelectedItem.Equals("58123") || combNordem.SelectedItem.Equals("58124") || combNordem.SelectedItem.Equals("58127") || combNordem.SelectedItem.Equals("58128")
                || combNordem.SelectedItem.Equals("58151") || combNordem.SelectedItem.Equals("58167") || combNordem.SelectedItem.Equals("58168") || combNordem.SelectedItem.Equals("58169") || combNordem.SelectedItem.Equals("58171") || combNordem.SelectedItem.Equals("58173") || combNordem.SelectedItem.Equals("58189") || combNordem.SelectedItem.Equals("58145"))
            {
                this.Validate();
                idTextBox.Text = Convert.ToString(id);
                this.gravar_avariaTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), diaDateTimePicker.Value, combNordem.SelectedItem.ToString(), txtModelo.Text, txtAvariaA.Text);


                MessageBox.Show("Avaria salva com sucesso!", "Salva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAvariaA.Clear();
                txtModelo.Clear();
                limpar();
                limparLEAR();
                LimparDianteira();

                id++;

                manutencao.ActiveForm.Refresh();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            limparLEAR();
            LimparDianteira();
            LimparTraseira();
        }

        private void gravar_avariaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                       
            
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text.Equals("1519"))
            {
                manutencao.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Lourdes; // Altera o background para 1519

                manutencao.ActiveForm.Refresh();

                manutencao.ActiveForm.Update();

                pnlDianteira.Visible = true;

                pnlLDAR.Visible = true;

                pnlLEAR.Visible = true;

                pnlTraseira.Visible = true;

                Modelo1519();
            }

            if (txtModelo.Text.Equals("1722"))
            {
                manutencao.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1722; // Altera o background para 1722

                Modelo1722();
                manutencao.ActiveForm.Refresh();

                manutencao.ActiveForm.Update();

                pnlDianteira.Visible = true;

                pnlLDAR.Visible = true;

                pnlLEAR.Visible = true;

                pnlTraseira.Visible = true;
            }

            if (txtModelo.Text.Equals("Ar condicionado"))
            {
                manutencao.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources._1519Ar_condicionado1; // Altera o background para Ar condicionado

                ModeloAR();
                manutencao.ActiveForm.Refresh();

                manutencao.ActiveForm.Update();

                pnlDianteira.Visible = true;

                pnlLDAR.Visible = true;

                pnlLEAR.Visible = true;

                pnlTraseira.Visible = true;
            }
        }

        private void combNordem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combNordem.SelectedItem.Equals("58001") || combNordem.SelectedItem.Equals("58003") || combNordem.SelectedItem.Equals("58011") || combNordem.SelectedItem.Equals("58014") || combNordem.SelectedItem.Equals("58019") || combNordem.SelectedItem.Equals("58020") || combNordem.SelectedItem.Equals("58023")
               || combNordem.SelectedItem.Equals("58023") || combNordem.SelectedItem.Equals("58033") || combNordem.SelectedItem.Equals("58042") || combNordem.SelectedItem.Equals("58049") || combNordem.SelectedItem.Equals("58053") || combNordem.SelectedItem.Equals("58054") || combNordem.SelectedItem.Equals("58061")
               || combNordem.SelectedItem.Equals("58065") || combNordem.SelectedItem.Equals("58070") || combNordem.SelectedItem.Equals("58073") || combNordem.SelectedItem.Equals("58077") || combNordem.SelectedItem.Equals("58078") || combNordem.SelectedItem.Equals("58079") || combNordem.SelectedItem.Equals("58089")
               || combNordem.SelectedItem.Equals("58091") || combNordem.SelectedItem.Equals("58092") || combNordem.SelectedItem.Equals("58098") || combNordem.SelectedItem.Equals("58102") || combNordem.SelectedItem.Equals("58110") || combNordem.SelectedItem.Equals("58111") || combNordem.SelectedItem.Equals("58118")
               || combNordem.SelectedItem.Equals("58122") || combNordem.SelectedItem.Equals("58131") || combNordem.SelectedItem.Equals("58132") || combNordem.SelectedItem.Equals("58135") || combNordem.SelectedItem.Equals("58145") || combNordem.SelectedItem.Equals("58150") || combNordem.SelectedItem.Equals("58152") || combNordem.SelectedItem.Equals("58153")
               || combNordem.SelectedItem.Equals("58155") || combNordem.SelectedItem.Equals("58157") || combNordem.SelectedItem.Equals("58160") || combNordem.SelectedItem.Equals("58161") || combNordem.SelectedItem.Equals("58162") || combNordem.SelectedItem.Equals("58163") || combNordem.SelectedItem.Equals("58164")
               || combNordem.SelectedItem.Equals("58165") || combNordem.SelectedItem.Equals("58166") || combNordem.SelectedItem.Equals("58174")) // Modelo de carros 1722
            {
                txtModelo.Text = "1722";

                manutencao.ActiveForm.Update();
            }

            if (combNordem.SelectedItem.Equals("58009") || combNordem.SelectedItem.Equals("58016") || combNordem.SelectedItem.Equals("58017") || combNordem.SelectedItem.Equals("58028") || combNordem.SelectedItem.Equals("58031") || combNordem.SelectedItem.Equals("58058") || combNordem.SelectedItem.Equals("58060")
            || combNordem.SelectedItem.Equals("58081") || combNordem.SelectedItem.Equals("58088") || combNordem.SelectedItem.Equals("58100") || combNordem.SelectedItem.Equals("58103") || combNordem.SelectedItem.Equals("58106") || combNordem.SelectedItem.Equals("58113") || combNordem.SelectedItem.Equals("58114")
            || combNordem.SelectedItem.Equals("58115") || combNordem.SelectedItem.Equals("58116") || combNordem.SelectedItem.Equals("58120") || combNordem.SelectedItem.Equals("58121") || combNordem.SelectedItem.Equals("58125") || combNordem.SelectedItem.Equals("58147") || combNordem.SelectedItem.Equals("58172")
            || combNordem.SelectedItem.Equals("58177") || combNordem.SelectedItem.Equals("58178") || combNordem.SelectedItem.Equals("58185") || combNordem.SelectedItem.Equals("58188") || combNordem.SelectedItem.Equals("58190") || combNordem.SelectedItem.Equals("58204") || combNordem.SelectedItem.Equals("58205")
            || combNordem.SelectedItem.Equals("58207") || combNordem.SelectedItem.Equals("58210") || combNordem.SelectedItem.Equals("58211") || combNordem.SelectedItem.Equals("58214") || combNordem.SelectedItem.Equals("58215") || combNordem.SelectedItem.Equals("58216") || combNordem.SelectedItem.Equals("58217")) //Modelo de carro Ar condicionado

            {
                txtModelo.Text = "Ar condicionado";
                manutencao.ActiveForm.Update();
            }

            if (combNordem.SelectedItem.Equals("58006") || combNordem.SelectedItem.Equals("58007") || combNordem.SelectedItem.Equals("58008") || combNordem.SelectedItem.Equals("58010") || combNordem.SelectedItem.Equals("58012") || combNordem.SelectedItem.Equals("58013") || combNordem.SelectedItem.Equals("58022")
                || combNordem.SelectedItem.Equals("58024") || combNordem.SelectedItem.Equals("58025") || combNordem.SelectedItem.Equals("58027") || combNordem.SelectedItem.Equals("58032") || combNordem.SelectedItem.Equals("58034") || combNordem.SelectedItem.Equals("58035") || combNordem.SelectedItem.Equals("58039")
                || combNordem.SelectedItem.Equals("58040") || combNordem.SelectedItem.Equals("58043") || combNordem.SelectedItem.Equals("58044") || combNordem.SelectedItem.Equals("58046") || combNordem.SelectedItem.Equals("58047") || combNordem.SelectedItem.Equals("58048") || combNordem.SelectedItem.Equals("58052")
                || combNordem.SelectedItem.Equals("58055") || combNordem.SelectedItem.Equals("58056") || combNordem.SelectedItem.Equals("58059") || combNordem.SelectedItem.Equals("58094") || combNordem.SelectedItem.Equals("58095") || combNordem.SelectedItem.Equals("58096") || combNordem.SelectedItem.Equals("58097")
                || combNordem.SelectedItem.Equals("58105") || combNordem.SelectedItem.Equals("58117") || combNordem.SelectedItem.Equals("58119") || combNordem.SelectedItem.Equals("58123") || combNordem.SelectedItem.Equals("58124") || combNordem.SelectedItem.Equals("58127") || combNordem.SelectedItem.Equals("58128")
                || combNordem.SelectedItem.Equals("58151") || combNordem.SelectedItem.Equals("58167") || combNordem.SelectedItem.Equals("58168") || combNordem.SelectedItem.Equals("58169") || combNordem.SelectedItem.Equals("58171") || combNordem.SelectedItem.Equals("58173") || combNordem.SelectedItem.Equals("58189")) // Modelo de carros 1519
            {
                txtModelo.Text = "1519";
                manutencao.ActiveForm.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
      
        }
    }
}











