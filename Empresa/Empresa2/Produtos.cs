using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySqlX;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Empresa2
{
    public class Produtos
    {
        
        private double _chapa90 = default(double);
        private double _chapa75 = default(double);
        private double _washprimer = default(double);
        private double _catalizador = default(double);
        private double _chapelco = default(double);
        private double _m60 = default(double);
        private double _cidadeRJ = default(double);
        private double _internorte = default(double);
        private double _nordem = default(double);
        private double _nordemg = default(double);
        private double _nordemt = default(double);
        private double _papel = default(double);
        private double _capsula = default(double);
        private double _seta = default(double);
        private double _cadeirante = default(double);
        private double _faixarefletiva = default(double);
        private double _peixinho = default(double);
        private double _duplaface = default(double);
        private double _fitafina = default(double);
        private double _fitagrossa = default(double);
        private double _trincob = default(double);
        private double _trincot = default(double);
        private double _peixao = default(double);
        private double _dobradicaLD = default(double);
        private double _dobradicaLE = default(double);
        private double _puxador = default(double);
        private double _massapoliester = default(double);
        private double _massafibra = default(double);
        private double _tintaverde = default(double);
        private double _catalisadormassa = default(double);
        private double _tintapreta = default(double);
        private double _redutor = default(double);
        private double _cidadeRJgrade = default(double);
        private double _disco80 = default(double);
        private double _cinzaarofarol = default(double);
        private double _chapafurada = default(double);

        public double chapa90
        {
            get => _chapa90;

            set => _chapa90 = value;
        }

        public double chapa75
        {
            get => _chapa75;

            set => _chapa75 = value;
        }

        public double washprimer
        {
            get => _washprimer;

            set => _washprimer = value;
        }

        public double catalizador
        {
            get => _catalizador;

            set => _catalizador = value;
        }

        public double chapelco
        {
            get => _chapelco;

            set => _chapelco = value;
        }

        public double m60
        {
            get => _m60;

            set => _m60 = value;
        }

        public double cidadeRJ
        {
            get => _cidadeRJ;

            set => _cidadeRJ = value;
        }

        public double internorte
        {
            get => _internorte;

            set => _internorte = value;
        }

        public double nordem
        {
            get => _nordem;

            set => _nordem = value;
        }

        public double nordemg
        {
            get => _nordemg;

            set => _nordemg = value;
        }

        public double nordemt
        {
            get => _nordemt;

            set => _nordemt = value;
        }

        public double papel
        {
            get => _papel;

            set => _papel = value;
        }

        public double capsula
        {
            get => _capsula;

            set => _capsula = value;
        }

        public double seta
        {
            get => _seta;

            set => _seta = value;
        }

        public double cadeirante
        {
            get => _cadeirante;

            set => _cadeirante = value;
        }

        public double faixarefletiva
        {
            get => _faixarefletiva;

            set => _faixarefletiva = value;
        }

        public double duplaface
        {
            get => _duplaface;

            set => _duplaface = value;
        }

        public double fitafina
        {
            get => _fitafina;

            set => _fitafina = value;
        }

        public double fitagrossa
        {
            get => _fitagrossa;

            set => _fitagrossa = value;
        }

        public double trincob
        {
            get => _trincob;

            set => _trincob = value;
        }

        public double trincot
        {
            get => _trincot;

            set => _trincot = value;
        }

        public double peixao
        {
            get => _peixao;

            set => _peixao = value;
        }

        public double peixinho
        {
            get => _peixinho;

            set => _peixinho = value;
        }

        public double dobradicaLD
        {
            get => _dobradicaLD;

            set => _dobradicaLD = value;
        }

        public double dobradicaLE
        {
            get => _dobradicaLE;

            set => _dobradicaLE = value;
        }

        public double puxador
        {
            get => _puxador;

            set => _puxador = value;
        }

        public double massapoliester
        {
            get => _massapoliester;

            set => _massapoliester = value;
        }

        public double massafibra
        {
            get => _massafibra;

            set => _massafibra = value;
        }

        public double tintaverde
        {
            get => _tintaverde;

            set => _tintaverde = value;
        }

        public double catalisadormassa
        {
            get => _catalisadormassa;

            set => _catalisadormassa = value;
        }

        public double tintapreta
        {
            get => _tintapreta;

            set => _tintapreta = value;
        }

        public double redutor
        {
            get => _redutor;

            set => _redutor = value;
        }

        public double cidadeRJgrade
        {
            get => _cidadeRJgrade;

            set => _cidadeRJgrade = value;
        }

        public double disco80
        {
            get => _disco80;

            set => _disco80 = value;
        }

        public double chapafurada
        {
            get => _chapafurada;

            set => _chapafurada = 279.89;
        }

    }
}
