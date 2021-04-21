using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    class Avion : Transporte
    {

        public Avion(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar()
        {
            SetStatus("Avanzando");
            return string.Format("El avión se encuentra avanzando");
        }

        public override string Detenerse()
        {
            SetStatus("Detenido");
            return string.Format("El avión ahora está en reposo.");
        }

    }
}
