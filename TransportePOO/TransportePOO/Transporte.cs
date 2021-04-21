using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    public abstract class Transporte : InterfaceMain
    {
        private int cantidadPasajeros;
        private string estado = "detenido";

        public Transporte (int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public int GetPasajeros()
        {
            return cantidadPasajeros;
        }
        public void SetPasajeros(int cantidad)
        {
            this.cantidadPasajeros = cantidad;

        }

        public string GetStatus()
        {
            return estado;
        }
        public void SetStatus(string estado)
        {
            this.estado = estado;

        }

        public string Status()
        {
            return GetStatus();
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
