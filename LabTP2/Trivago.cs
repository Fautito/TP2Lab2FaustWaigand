using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP2
{
    
    class Trivago
    {
        //acciones con reservas
        public Trivago(decimal pb)
        {
            precioBase = pb;
            FileStream fsClientes = new FileStream(Application.StartupPath+"clientes.bin",FileMode.OpenOrCreate,FileAccess.Read);
            FileStream fsAlojamientos = new FileStream(Application.StartupPath + "alojamientos.bin", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fsReservas = new FileStream(Application.StartupPath + "reservas.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();


            Alojamientos = new ArrayList();
            Clientes = new ArrayList();
            Reservas = new ArrayList();
            //Alojamientos.Add(new Casa( 2, "almafuerte", new bool[] { true, false, true }, 2));
            //Alojamientos.Add(new Habitacion(3, "churruarin", 3, "4b"));

            //Clientes.Add(new Cliente("eduardo", 1, "lalala", "456"));
            //Clientes.Add(new Cliente("juancru", 2, "lele", "0303"));
            if (fsClientes.Length>0)Clientes = (ArrayList)bf.Deserialize(fsClientes);
            fsClientes.Close();
            if (fsAlojamientos.Length > 0) Alojamientos = (ArrayList)bf.Deserialize(fsAlojamientos);
            fsAlojamientos.Close();
            if (fsReservas.Length > 0) Reservas = (ArrayList)bf.Deserialize(fsReservas);
            fsReservas.Close();
            
        }


        public ArrayList Clientes;
        public ArrayList Alojamientos;
        public ArrayList Reservas;


        static public decimal precioBase;

        //acciones con reservas

        public Reserva[] MostrarReservas()
        {
            return (Reserva[])Reservas.ToArray();
        }
        public void CrearReservas(Reserva r)
        {
            Reservas.Add(r);
        }
        public void ModificarReservas(int i, Reserva r)
        {
            Reservas[i] = r;
        }

        public void CancelarReserva(Reserva r)
        {
            Reservas.RemoveAt(Reservas.IndexOf(r));
        }

        //acciones conc clientes
        public void RegistrarCliente(Cliente c)
        {
            Clientes.Add(c);
        }
        public Cliente[] MostrarCliente()
        {
            return (Cliente[])Clientes.ToArray();
        }

        //acciones con alojamientos
        public Alojamiento[] MostrarAlojamientos(Alojamiento a)
        {
            Alojamiento[] aloj;
            if (a is Casa)
            {
                Casa c = (Casa)a;
                ArrayList res = new ArrayList();
                foreach(Alojamiento casa in Alojamientos)
                {
                    if(casa is Casa)
                    {
                        Casa casa2 = (Casa)casa;
                        if (casa2.Equals(c)) res.Add(casa2);
                    }
                    
                }
                aloj = (Alojamiento[])res.ToArray(typeof(Casa)) ;
            }
            else if (a is Habitacion)
            {
                Habitacion h = (Habitacion)a;
                ArrayList res = new ArrayList();
                foreach (Alojamiento hab in Alojamientos)
                {
                    if (hab is Habitacion)
                    {
                        Habitacion habitacion = (Habitacion)hab;
                        if (habitacion.Equals(h)) res.Add(habitacion);
                    }
                    
                }
                aloj = (Alojamiento[])res.ToArray(typeof(Habitacion));
            }
            else
            {
                throw new Exception("tipo de propiedad invalido");
            }

            return aloj;
        }


        //metodo sobrecargado para el caso de q no deba filtrar la busqueda
        public Alojamiento[] MostrarAlojamientos()
        {
            Alojamiento[] a = (Alojamiento[])Alojamientos.ToArray(typeof(Alojamiento));
            return a;
        }

        public void AgregarAlojamiento(Alojamiento a)
        {
            Alojamientos.Add(a);
        }
        public void ModificarAlojamiento(int i,Alojamiento a)
        {
            Alojamientos[i] = a;
        }

        public void QuitarAlojamiento(Alojamiento a)
        {
            Alojamientos.RemoveAt(Alojamientos.IndexOf(a));
        }

        public void BackUp()
        {
            FileStream fsClientes = new FileStream(Application.StartupPath + "clientes.bin", FileMode.Truncate, FileAccess.Write);
            FileStream fsAlojamientos = new FileStream(Application.StartupPath + "alojamientos.bin", FileMode.Truncate, FileAccess.Write);
            FileStream fsReservas = new FileStream(Application.StartupPath + "reservas.bin", FileMode.Truncate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            //bf.Serialize(fsClientes, Clientes);
            bf.Serialize(fsAlojamientos, Alojamientos);
            //bf.Serialize(fsReservas, Reservas);
            fsReservas.Close();
            fsAlojamientos.Close();
            fsClientes.Close();
        }
    }
}
