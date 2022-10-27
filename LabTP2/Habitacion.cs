﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    [Serializable]
    class Habitacion : Alojamiento
    {
        public Habitacion(int capacidad, string direccion, int est, string hab) : base( capacidad, direccion)
        {
            this.Estrellas = est;
            this.numeroHabitacion = hab;
        }


        private int estrellas;
        public int Estrellas { get { return estrellas; } set { estrellas = value; } }//controlar que solo entre 2 o 3

        private string numeroHabitacion;
        public string NumeroHabitacion { get { return numeroHabitacion; } set { numeroHabitacion = value; } }


        public override decimal PrecioPorDia()
        {
            return Trivago.precioBase / 2;
        }

        public override bool Equals(object obj)
        {
            Habitacion h = (Habitacion)obj;
            return h.estrellas == this.estrellas && h.Capacidad == this.Capacidad;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}