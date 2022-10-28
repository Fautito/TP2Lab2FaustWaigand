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
            if (fsReservas.Length > 0) Reservas = (ArrayList)bf.Deserialize(fsReservas);
            fsReservas.Close();
            if (fsClientes.Length>0)Clientes = (ArrayList)bf.Deserialize(fsClientes);
            fsClientes.Close();
            if (fsAlojamientos.Length > 0) Alojamientos = (ArrayList)bf.Deserialize(fsAlojamientos);
            fsAlojamientos.Close();
            
            
        }


        public ArrayList Clientes;
        public ArrayList Alojamientos;
        public ArrayList Reservas;


        static public decimal precioBase;

        //acciones con reservas

        public Reserva[] MostrarReservas()
        {
            return (Reserva[])Reservas.ToArray(typeof(Reserva));
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
            return (Cliente[])Clientes.ToArray(typeof(Cliente));
        }




        //acciones con alojamientos
        public Alojamiento[] MostrarAlojamientos(Alojamiento a)
        {
            ArrayList res = new ArrayList();

            if (a.GetType() == typeof(Casa)) 
                a = (Casa)a;
            else   
                a = (Habitacion)a;
    
            foreach(Alojamiento alojamiento in Alojamientos)
            {
                if (alojamiento.GetType() == a.GetType() && alojamiento.Equals(a)) res.Add(alojamiento);
            }

            return (Alojamiento[])res.ToArray(typeof(Alojamiento));
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

        //falta palicar este metodo
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


            ////por ahora solo esta serializando alojamientos
            bf.Serialize(fsAlojamientos, Alojamientos);
            bf.Serialize(fsReservas, Reservas);
            bf.Serialize(fsClientes, Clientes);
            
            
            fsReservas.Close();
            fsAlojamientos.Close();
            fsClientes.Close();
        }
    }
}
