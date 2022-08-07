using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Chofer
    {
        private int _IdChofer;      
        private string _Nombre;
        private string _Apellido;
        private string _Cedula;
        private bool _LoCupado;
        private DateTime _FechaNac;

        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public bool LoCupado { get => _LoCupado; set => _LoCupado = value; }
        public DateTime FechaNac { get => _FechaNac; set => _FechaNac = value; }
    }

}
