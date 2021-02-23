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
    public partial class PesquisarAV : Form
    {
        string line = "";

        OpenFileDialog openF = new OpenFileDialog();
        public PesquisarAV()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
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

        }
}
