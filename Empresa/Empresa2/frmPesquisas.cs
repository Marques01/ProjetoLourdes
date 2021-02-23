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

namespace Empresa2
{
    public partial class frmPesquisas : Form
    {
        string line = String.Empty;
        public frmPesquisas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog();

            if (openF.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openF.FileName);

                while (line != null)
                {
                    line = sr.ReadLine();

                    if (line != null)
                    {
                        avariastexto.Text += line;
                    }
                }
                sr.Close();
            }
        }

        private void gravar_avariaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gravar_avariaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vnslourdesDataSet);

        }

        private void frmPesquisas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.gravar_avaria'. Você pode movê-la ou removê-la conforme necessário.
            this.gravar_avariaTableAdapter.Fill(this.vnslourdesDataSet.gravar_avaria);
            // TODO: esta linha de código carrega dados na tabela 'vnslourdesDataSet.gravar_avaria'. Você pode movê-la ou removê-la conforme necessário.
            this.gravar_avariaTableAdapter.Fill(this.vnslourdesDataSet.gravar_avaria);

        }

        private void gravar_avariaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gravar_avariaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vnslourdesDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
