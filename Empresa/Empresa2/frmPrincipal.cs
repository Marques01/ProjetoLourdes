using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Empresa2
{
    public partial class frmPrincipal : Form
    {
        string senhaC = "controle0101";
        string senhajc = "044194";
        string senhaA = "anotador00";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Logado()
        {
            imgDesfoque.Visible = true; // Ativa a visibilidade da imagem desfocada
            imgDesfoque.Enabled = true;// Ativa a imagem desfocada

            txtSenha.Enabled = false; // Desativa o campo da senha
            txtSenha.Visible = false; // Desativa a visiblidade do campo de senha

            lblSenha.Visible = false; // Desativa a visibilidade da Label Senha
            lblSenha.Enabled = false; // Desativa a Label senha

            btnEntrar.Visible = false; // Desativa a visbilidade do botao entrar
            btnEntrar.Enabled = false; // Desativa o botao entrar

            frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
        }


        public void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Equals("anotador") || txtUsuario.Text.Equals("controle") || txtUsuario.Text.Equals("carlinhos"))
            {
                lblSenha.Visible = true; // Ativa a visibilidade da Label Senha
                lblSenha.Enabled = true; // Ativa a Label senha

                txtSenha.Enabled = true; // Ativa o textbox para digitar senha
                txtSenha.Visible = true; // Ativa a visibilidade do textbox para digitar a senha

                btnEntrar.Visible = true; // Ativa a visibilidade do botão entrar
                btnEntrar.Enabled = true; // Ativa o botão entrar                               
            }

            if (txtUsuario.Text != "anotador")
            {
                imgDesfoque.Visible = false;
                imgDesfoque.Enabled = false;
            }

            if (txtUsuario.Text != "controle" && txtUsuario.Text != "anotador" && txtUsuario.Text != "carlinhos")
            {
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                btnEntrar.Visible = false;
                imgDesfoque.Visible = false;
                imgDesfoque.Enabled = false;
                txtSenha.Clear();
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtSenha.Text != senhaC && txtUsuario.Text.Equals("controle") && txtSenha.Text != String.Empty)
            {
                MessageBox.Show("Senha incorreta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtSenha.Text.Equals(String.Empty) && txtSenha.Text != senhaC && txtUsuario.Text.Equals("controle"))
            {
                MessageBox.Show("Você não digitou a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtSenha.Text.Equals(senhaC))
            {
                Logado();

                AvariaAR NovaAvaria = new AvariaAR();
                NovaAvaria.ShowDialog(); // Abre o formulário do Controle
            }


            if (txtSenha.Text != senhaA && txtUsuario.Text.Equals("anotador"))
            {
                MessageBox.Show("Senha incorreta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtUsuario.Text.Equals("anotador") || txtUsuario.Text.Equals("carlinhos") && txtSenha.Text.Equals(senhaA) || txtSenha.Text.Equals(senhajc))
            {
                manutencao avariaanotador = new manutencao();
                avariaanotador.ShowDialog(); // Abre o fomulário Anotador

                frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text.Equals(senhaA))
            {
                Logado();

                manutencao avariaanotador = new manutencao();

                avariaanotador.ShowDialog(); // Abre o formulário anotador

                frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("carlinhos") && txtSenha.Text.Equals(senhajc))
            {
                Logado();

                manutencao avariaanotador = new manutencao();

                avariaanotador.ShowDialog(); // Abre o formulário anotador

                frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não digitou a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text != String.Empty && txtSenha.Text != senhaA)
            {
                MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("controle") && txtSenha.Text.Equals(senhaC))
            {
                Logado();

                AvariaAR NovaAvaria = new AvariaAR();

                NovaAvaria.ShowDialog(); // Abre o formulário do controle
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("controle") && txtSenha.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não digitou a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("controle") && txtSenha.Text != String.Empty && txtSenha.Text != senhaC)
            {
                MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text.Equals(senhaA))
            {
                Logado();

                manutencao avariaanotador = new manutencao();

                avariaanotador.ShowDialog();

                frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
            }


            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("carlinhos") && txtSenha.Text.Equals(senhajc))
            {
                Logado();

                manutencao avariaanotador = new manutencao();

                avariaanotador.ShowDialog();

                frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
            }



            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não digitou a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("anotador") && txtSenha.Text != String.Empty && txtSenha.Text != senhaA)
            {
                MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("controle") && txtSenha.Text.Equals(senhaC))
            {
                Logado();

                AvariaAR NovaAvaria = new AvariaAR();

                NovaAvaria.ShowDialog();
            }

            if (e.KeyCode.Equals(Keys.Enter) && txtUsuario.Text.Equals("controle") && txtSenha.Text.Equals(String.Empty))
            {
                MessageBox.Show("Você não digitou a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyCode == Keys.Enter && txtUsuario.Text == "controle" && txtSenha.Text != "" && txtSenha.Text != senhaC)
            {
                MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmPrincipal.ActiveForm.BackgroundImage = global::Empresa2.Properties.Resources.DSC_0003;
        }
    }
}


