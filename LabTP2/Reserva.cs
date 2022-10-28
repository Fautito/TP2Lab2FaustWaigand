using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    [Serializable]
    class Reserva
    {
        public Reserva(Cliente c, DateTime fechaRes, DateTime fechaCheck, int dias, Alojamiento aloj)
        {
            this.c = c;
            this.fechaReserva = fechaRes;
            this.fechaCheckIn = fechaCheck;
            this.fechaCheckOut = this.fechaCheckIn.AddDays(dias-1);
            this.dias = dias;
            this.alojamiento = aloj;
            alojamiento.Reservar(this);
        }

        //alojamiento
        public Alojamiento alojamiento;

        //cliente
        private Cliente c;
        public Cliente Cliente { get { return c; } }

        private DateTime fechaCheckIn;
        public DateTime FechaChekIn { get { return fechaCheckIn; } }
        private DateTime fechaCheckOut;
        public DateTime FechaChekOut { get { return fechaCheckOut; } }
        private DateTime fechaReserva;
        public DateTime FechaReserva { get { return fechaReserva; } }

        private int dias;
        public int Dias { get { return dias; } set { dias = value; } }


        public decimal CostoTotal()
        {
            return 0;
        }
    }
}
