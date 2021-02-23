using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2
{
    public class CalcularDianteira_Traseira: Produtos
    {

        public double Ponteira_TD_TE_CP()
        {
            double Ponteira_TD_TE_CP = (chapelco * 0.10) + (redutor * 0.10) + faixarefletiva + (massafibra / 2) + (massapoliester / 2) + (fitafina / 2) + (papel / 4) + disco80;

            return Ponteira_TD_TE_CP;

             // Valor cobrado da ponteira traseira T/D E T/E Carroceria / pintura
        }

        public double Ponteira_TD_TE_P()
        {
            double Ponteira_TD_TE_P = (0.10 * chapelco) + (washprimer / 2) + (3 / papel) + (2 / fitagrossa) + faixarefletiva;

            return Ponteira_TD_TE_P;

             // Valor cobrado da ponteira traseira T/D - Pintura E T/E
        }

        public double Parachoque_Traseiro_P()
        {
            double Parachoque_Traseiro_P = (0.20 * chapelco) + (washprimer / 2) + (3 / papel) + (2 / fitagrossa);

            return Parachoque_Traseiro_P;

             // Valor cobrado do para choque traseiro Pintura
        }

        public double Parachoque_Traseiro_CP()
        {
            double Parachoque_Traseiro_CP = (chapelco * 0.20) + (redutor * 0.10) + (massafibra / 2) + (massapoliester / 2) + (fitafina / 1.5) + (papel / 3) + disco80;

            return Parachoque_Traseiro_CP;

            // Valor cobrado do para choque traseiro Carroceria Pintura
        }


        public double Parachoque_Dianteiro_P()
        {
            double Parachoque_Dianteiro_P = (m60 * 0.10) + (tintapreta * 0.10) + (redutor * 0.10) + fitafina + (papel / 1.5);

            return Parachoque_Dianteiro_P;

            // Valor cobrado do para choque dianteiro Pintura
        }

        public double Parachoque_Dianteiro_CP()
        {
            double Parachoque_Dianteiro_CP = (m60 * 0.10) + (tintapreta * 0.10) + (massafibra / 2) + (massapoliester / 2) + (redutor * 0.10) + fitafina + (papel / 1.5) + disco80;

            return Parachoque_Dianteiro_CP;

            // Valor cobrado do para choque dianteiro Carroceria Pintura
        }


        public double Coluna_TD_TE_CP()
        {
            double Coluna_TD_TE = (tintaverde * 0.10) + (massafibra / 2) + (massapoliester / 2) + (redutor * 0.10) + (fitagrossa / 2) + (papel / 3) + (disco80 * 2);

            return Coluna_TD_TE;

             // Valor cobrado da coluna traseira  Carroceria / Pintura
        }

        public double Coluna_TD_TE_P()
        {
            double Coluna_TD_TE_P = (tintaverde * 0.10) + (redutor * 0.10) + (fitafina / 2) + (papel / 4);

            return Coluna_TD_TE_P;

             // Valor cobrado da coluna traseira Pintura
        }

        public double Ponteira_DD_DE_P()
        {
            double Ponteira_DD_DE_P = (m60 * 0.10) + (redutor * 0.05) + (fitafina / 1.5) + (papel / 2);

            return Ponteira_DD_DE_P;

             // Valor cobrado da ponteira D/E - Pintura
        }

        public double Ponteira_DD_DE_CP()
        {
            double Ponteira_DD_DE_CP = (m60 * 0.10) + (massafibra / 2) + (massapoliester / 2) + disco80 + (redutor * 0.05) + (fitafina / 1.5) + (papel / 2) + disco80;

            return Ponteira_DD_DE_CP;

            // Valor cobrado da ponteira D/E D/D - Pintura
        }

        public double Traseira_Meio_CP()
        {
            double Traseira_Meio_CP = (m60 * 0.30) + massafibra + (massapoliester / 2) + disco80 + cadeirante + (nordemt * 6) + internorte + (redutor * 0.10) + fitagrossa + (papel / 1.5);

            return Traseira_Meio_CP;

            // Valor cobrado da traseira 2 Carroceria / PINTURA
        }

        public double Traseira_Meio_P()
        {
            double Traseira_Meio_P = (m60 * 0.30) + cadeirante + (nordemt * 6) + internorte + (redutor * 0.10) + fitagrossa + (papel / 1.5);

            return Traseira_Meio_P;

            // Valor cobrado da traseira 2 PINTURA
        }

        public double Grade_Dianteira_CP()
        {
            double Grade_Dianteira_CP = (tintaverde * 0.10) + massafibra + (massapoliester / 2) + disco80 + (tintapreta * 0.10) + (redutor * 0.05) + fitafina + (papel / 2) + (nordemg * 6) + cidadeRJgrade;

            return Grade_Dianteira_CP;

           // Valor cobrado da grade dianteira - Carroceria / Pintura
        }

        public double Grade_Dianteira_P()
        {
            double Grade_Dianteira_P = (tintaverde * 0.10) + (washprimer / 2) + (tintapreta * 0.10) + (redutor * 0.05) + fitafina + (papel / 2) + (nordemg * 6) + cidadeRJgrade;

            return Grade_Dianteira_P;

          // Valor cobrado da grade dianteira  Pintura
        }

        /*
        58001
        58003
        58006
        58007
        58008
        58009
        58010
        58011
        58012
        58013
        58014
        58016
        58017
        58019
        58020
        58022
        58023
        58024
        58025
        58027
        58028
        58031
        58032
        58033
        58034
        58035
        58039
        58040
        58042
        58043
        58044
        58046
        58047
        58048
        58049
        58052
        58053
        58054
        58055
        58056
        58058
        58059
        58060
        58061
        58063
        58065
        58070
        58073
        58075
        58076
        58077
        58078
        58079
        58081
        58084
        58085
        58088
        58089
        58091
        58092
        58094
        58095
        58096
        58097
        58098
        58100
        58102
        58103
        58105
        58106
        58110
        58111
        58113
        58114
        58115
        58116
        58117
        58118
        58119
        58120
        58121
        58122
        58123
        58124
        58125
        58127
        58128
        58131
        58132
        58135
        58147
        58150
        58151
        58152
        58153
        58155
        58157
        58160
        58161
        58162
        58163
        58164
        58165
        58166
        58167
        58168
        58169
        58171
        58172
        58173
        58174
        58177
        58178
        58185
        58188
        58189
        58190
        58204
        58205
        58207
        58210
        58211
        58214
        58215
        58216
        58217

        
        */
    }
}
