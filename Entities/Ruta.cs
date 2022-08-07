using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ruta
    {
        private int _IdRuta;
        private string _Nombre;
        private bool _LoCupado;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool LoCupado { get => _LoCupado; set => _LoCupado = value; }
        public int IdRuta { get => _IdRuta; set => _IdRuta = value; }
    }
}
