using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Empresa2
{
    class clsCOR
    {

        private string data, carro, avaria, tipo;
        public void COR_GRAVARLD(string data, string carro, string avaria, string tipo)
        {

            this.data = data;

            this.carro = carro;

            this.avaria = avaria;

            this.tipo = tipo;            

        }

        
        public void EscreverCORLD(string data, string carro, string avaria)
        {
            using (System.IO.StreamWriter corretiva = new System.IO.StreamWriter(@"C:\RelatorioAvarias\txt\" + data + "-" + carro + ".txt"))
            {

                corretiva.WriteLine("Data: " + data + "\t\n" + "Nº Ordem: " + carro + "\t\n" + "Avaria: " + avaria + "\t\n");
                corretiva.Close();

            }

        }

    }
}
