using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2
{
   public class CalcularArCondiconado: Produtos
    {
        
        public double total_check0_ArCondicionado()
        {
            double total_check0_ArCondicionado = (massafibra / 2) + (massapoliester / 2) + (m60 * 0.20) + faixarefletiva + (2 * disco80) + (papel / 2) + fitafina + (redutor * 0.05);

            return total_check0_ArCondicionado;

            // Valor cobrado check0 Lado Direito Carroceria / Pintura
        }

        public double total_check1_ArCondicionado()
        {
            double total_check1_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + capsula + faixarefletiva;

            return total_check1_ArCondicionado;

            // Valor cobrado check1 Lado direito Carroceria / Pintura 
        }

        public double total_check2_ArCondicionado()
        {
            double total_check2_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + cidadeRJ + faixarefletiva;

            return total_check2_ArCondicionado;

            // Valor cobrado check2 Lado Direito Carroceria / Pintura
        }

        public double total_check3_ArCondicionado()
        {
            double total_check3_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + cidadeRJ + faixarefletiva;

            return total_check3_ArCondicionado;

            // Valor cobrado check3 Lado Direto Carroceria / Pintura
        }

        public double total_check4_ArCondicionado()
        {
            double total_check4_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + internorte + faixarefletiva + cadeirante;

            return total_check4_ArCondicionado;

            // Valor cobrado heck4 lado Direito Carroceria / Pintura
        }
        
        public double total_check5_ArCondicionado()
        {
            double total_check5_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (5 * nordem) + faixarefletiva + seta;

            return total_check5_ArCondicionado;

            // Valor cobrado check5 Lado direito Carroceria / Pintura
        }

        public double total_check6_ArCondicionado()
        {
            double total_check6_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + nordem + faixarefletiva + seta;

            return total_check6_ArCondicionado;

            // Valor cobrado check6 Lado Direito Carroceria / Pintura
        }

        public double total_check7_ArCondicionado()
        {
            double total_check7_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + peixinho;

            return total_check7_ArCondicionado;

            // Valor cobrado check7 Lado Direito Carroceria / Pintura
        }

        public double total_check8_ArCondicionado()
        {
            double total_check8_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60);

            return total_check8_ArCondicionado;

            // Valor cobrado check8 Lado Direito Carroceria / Pintura
        }

        public double total_check9_ArCondicionado()
        {
            double total_check9_ArCondicionado = (chapa75 / 4) + (0.1 * chapelco) + (0.2 * washprimer) + (0.25 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check9_ArCondicionado;

            // Valor cobrado check9 Lado Direito Carroceria / Pintura
        }

        public double total_check10_ArCondicionado()
        {
            double total_check10_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60) + peixinho;

            return total_check10_ArCondicionado;

            // valor cobrado check10 Lado Direito Carroceria / Pintura
        }

        public double total_check11_ArCondicionado()
        {
            double total_check11_ArCondicionado = (chapa75 / 3) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check11_ArCondicionado;

            // Valor cobrado check11 lado Direito Carroceria / Pintura
        }

        public double total_check12_ArCondicionado()
        {
            double total_check12_ArCondicionado = (chapa75 / 3) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check12_ArCondicionado;

            // Valor cobrado check12 lado Direito Carroceria / Pintura
        }

        public double total_check13_ArCondicionado()
        {
            double total_check13_ArCondicionado = (chapa75 / 5) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.025 * m60) + peixinho;

            return total_check13_ArCondicionado;

            // Valor cobrado check13 lado Direito Carroceria / Pintura
        }

        public double total_check14_ArCondicionado()
        {
            double total_check14_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60) + (2 * trincot) + dobradicaLD + dobradicaLE + (2 * puxador);

            return total_check14_ArCondicionado;

            // valor cobrado check14 Lado Direito Carroceria / Pintura
        }

        public double total_check15_ArCondicionado()
        {
            double total_check15_ArCondicionado = (chapa75 / 5) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check15_ArCondicionado;

            // Valor cobrado check15 Lado Direito Carroceria / Pintura
        }

        public double total_check16_ArCondicionado()
        {
            double total_check16_ArCondicionado = (chapa75 / 5) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check16_ArCondicionado;

            // Valor cobrado check16 Lado Direito Carroceria / Pintura
        }

        public double total_check17_ArCondicionado()
        {
            double total_check17_ArCondicionado = (chapa75 / 4) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60) + peixao;

            return total_check17_ArCondicionado;

            // Valor cobrado check17 Lado direito Carroceria / Pintura
        }

        public double total_check1LE_ArCondicionado()
        {
            double total_check1LE_ArCondicionado = (chapa90 / 3) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (6 * nordem) + faixarefletiva + capsula;

            return total_check1LE_ArCondicionado;

            // Valor cobrado check1 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check2LE_ArCondicionado()
        {
            double total_check2LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + capsula + faixarefletiva + (6 * nordem);

            return total_check2LE_ArCondicionado;

            // Valor cobrado check2 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check3LE_ArCondicionado()
        {
            double total_check3LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + internorte + faixarefletiva;

            return total_check3LE_ArCondicionado;

            // valor cobrado check3 lado esquerdo Carroceria / Pintura
        }

        public double total_check4LE_ArCondicionado()
        {
            double total_check4LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + cadeirante + faixarefletiva;

            return total_check4LE_ArCondicionado;

            // valor cobrado check4 Lado esquerdo Carroceria / Pintura
        }

        public double total_check5LE_ArCondicionado()
        {
            double total_check5LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + capsula + faixarefletiva;

            return total_check5LE_ArCondicionado;

            // Valor cobrado check5 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check6LE_ArCondicionado()
        {
            double total_check6LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + cidadeRJ + faixarefletiva;

            return total_check6LE_ArCondicionado;

            // Valor cobrado check6 lado Esquerdo Carroceria / Pintura
        }

        public double total_check7LE_ArCondicionado()
        {
            double total_check7LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + cidadeRJ + faixarefletiva;

            return total_check7LE_ArCondicionado;

            // Valor cobrado check7 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check8LE_ArCondicionado()
        {
            double total_check8LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + capsula;

            return total_check8LE_ArCondicionado;

            // valor cobrado check8 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check9LE_ArCondicionado()
        {
            double total_check9LE_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60) + (2 * trincob) + peixao + dobradicaLE + dobradicaLD;

            return total_check9LE_ArCondicionado;

            // Valor cobrado check9 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check10LE_ArCondicionado()
        {
            double total_check10LE_ArCondicionado = (chapa75 / 3) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check10LE_ArCondicionado;

            // Valor cobrado check10 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check11LE_ArCondicionado()
        {
            double total_check11LE_ArCondicionado = (chapa75 / 3) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60) + peixinho;

            return total_check11LE_ArCondicionado;

            // Valor cobrado check11 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check12LE_ArCondicionado()
        {
            double total_check12LE_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60) + (2 * trincob) + puxador + dobradicaLD + dobradicaLE;

            return total_check12LE_ArCondicionado;

            // Valor cobrado check12 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check13LE_ArCondicionado()
        {
            double total_check13LE_ArCondicionado = (chapa75 / 5) + (0.1 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.025 * m60);

            return total_check13LE_ArCondicionado;

            // Valor cobrado check13 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check14LE_ArCondicionado()
        {
            double total_check14LE_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60) + (2 * trincot) + dobradicaLE + dobradicaLD + (2 * puxador);

            return total_check14LE_ArCondicionado;

            // Valor cobrado check14 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check15LE_ArCondicionado()
        {
            double total_check15LE_ArCondicionado = (chapa75 / 2.5) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60) + peixinho;

            return total_check15LE_ArCondicionado;

            // Valor cobrado check15 lado Esquerdo Carroceria / Pintura
        }

        public double total_check16LE_ArCondicionado()
        {
            double total_check16LE_ArCondicionado = (chapa75 / 4) + (0.1 * chapelco) + (0.2 * washprimer) + (0.25 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.05 * m60);

            return total_check16LE_ArCondicionado;

            // Valor cobrado check16 Lado Esquerdo Carroceria / Pintura
        }

        public double total_check17LE_ArCondicionado()
        {
            double total_check17LE_ArCondicionado = (chapa75 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + (0.10 * m60);

            return total_check17LE_ArCondicionado;

            // Valor cobrado check17 Lado Esquerdo Carroceria / Pintura
        }

       public double total_check18LE_ArCondicionado()
        {
            double total_check18LE_ArCondicionado = (chapa90 / 2) + (0.2 * chapelco) + (0.2 * washprimer) + (0.5 * catalizador) + (0.3 * papel) + (0.3 * fitagrossa) + (0.2 * duplaface) + peixinho;

            return total_check18LE_ArCondicionado;

            // Valor cobrado check18 Lado Esquerdo Carroceria / Pintura
        }
        
    }
}
