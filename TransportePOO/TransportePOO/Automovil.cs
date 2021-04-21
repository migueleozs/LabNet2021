using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    class Automovil : Transporte
    {
        public Automovil (int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }

        public override string Avanzar()
        {
            SetStatus("Avanzando");
            return string.Format("El Automovil se encuentra avanzando");
        }

        public override string Detenerse()
        {
            SetStatus("Detenido");
            return string.Format("El automovil ahora está en reposo.");
        }
    }
}
