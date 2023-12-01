using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_Examen
{
    public class Nodo
    {
        public Carro DatosCarro { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Carro carro)
        {
            DatosCarro = carro;
            Siguiente = null;
        }
    }
}
