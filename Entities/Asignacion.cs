using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Asignacion
    {
        private int _IdAsignacion;
        private int _IdChofer;
        private int _IdBus;
        private int _IdRuta;
        private bool _lAsignada;

        public int IdAsignacion { get => _IdAsignacion; set => _IdAsignacion = value; }
        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public int IdBus { get => _IdBus; set => _IdBus = value; }
        public int IdRuta { get => _IdRuta; set => _IdRuta = value; }
        public bool LAsignada { get => _lAsignada; set => _lAsignada = value; }
    }
}
