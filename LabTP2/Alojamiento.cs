using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    [Serializable]
    abstract class Alojamiento
    {
        public Alojamiento(int capacidad, string direccion)
        {
            this.capacidad = capacidad;
            this.direccion = direccion;

        }
        
        //imagenes


        //reservas
        ArrayList reservas = new ArrayList();
        public void Reservar(Reserva r)
        {
            reservas.Add(r);
        }

        public Reserva[] mostrarReservas()
        {
            return (Reserva[])reservas.ToArray(typeof(Reserva));
        }

        public void CancelarReserva(Reserva r)
        {
            reservas.RemoveAt(reservas.IndexOf(r));
        }


        private int capacidad;
        public int Capacidad { get { return capacidad; } set { capacidad = value; } }


        private string direccion;
        public string Direccion { get { return direccion; } set { direccion = value; } }


        abstract public decimal PrecioPorDia();


    }
}