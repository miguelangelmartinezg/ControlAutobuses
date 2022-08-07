using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Autobus
    {
        private int _IdBus;
        private int _IdMarca;
        private int _IdModelo;
        private int _IdColor;
        private int _IdAno;
        private string _Placa;
        bool _lOcuapdo;

        public int IdBus { get => _IdBus; set => _IdBus = value; }
        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public int IdModelo { get => _IdModelo; set => _IdModelo = value; }
        public int IdColor { get => _IdColor; set => _IdColor = value; }
        public int IdAno { get => _IdAno; set => _IdAno = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public bool LOcuapdo { get => _lOcuapdo; set => _lOcuapdo = value; }
    }
}
