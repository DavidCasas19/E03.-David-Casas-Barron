using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List
{
    
    public class DatosTarea
    {
        List<Tareas> lista = new List<Tareas>();
        //hacemos un metodo donde el usuario pueda ingresar los datos sobre las tareas
        public void GetTareas()
        {
            //le pedimos al usuario que ingrese los datos
            Tareas Tar = new Tareas();

            Console.WriteLine("Ingresa tu nombre");
            Tar.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre de la tarea");
            Tar.Tarea = Console.ReadLine();
            Console.WriteLine("Ingresa la hora");
            Tar.Hora = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha");
            Tar.Fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingresa el status actual de la tarea");
            Tar.Status = Console.ReadLine();
            Console.WriteLine("   ");
            //hacemos un lista.add para que los datos que ingrese el usuario se guarden en la lista y se puedan desplegar y usar mas adelante
            lista.Add(Tar);

        }

        //un metodo donde le mostremos al usuario pueda ver solo las tareas asignadas y a quien estan asignadas 
        public void Listadetareas()
        {
            //hacemos un foreach para que haga lo mismo con todos los objetos en la lista
            foreach (Tareas Ta in lista)
            {
                Console.WriteLine("Nombre de la persona" + "  " + Ta.Nombre);
                Console.WriteLine("Nombre de la tarea" + "  " + Ta.Tarea);
                Console.WriteLine("");

            }
         
        }
        //hacemos un metodo ara que el usuario pueda ver todos los detalles de las tareas
        public void DetallesDeTareas()
        {
            //hacemos un foreach para que haga lo mismo con todos los objetos en la lista
            foreach (Tareas Ta in lista)
            {
                Console.WriteLine("Nombre de la persona" + "  " + Ta.Nombre);
                Console.WriteLine("Nombre de la tarea asignada" + "  " + Ta.Tarea);
                Console.WriteLine("Hora asignada" + "  " + Ta.Hora);
                Console.WriteLine("Fecha asignada" + "  " + Ta.Fecha.ToString("MM/dd/yyyy"));
                Console.WriteLine("Status de la tarea asignada"+"  "+Ta.Status);
                Console.WriteLine("   ");

            }
         
        }
        //hacemos un metodo donde el usuario vea el status actual de las tareas y el nombre de a quien estan asignadas
        public void ListaDeEstatus()
        {
            //hacemos un foreach para que haga lo mismo con todos los objetos en la lista
            foreach (Tareas Ta in lista)
            {
                Console.WriteLine("Nombre de la persona" + "  " + Ta.Nombre);
                Console.WriteLine("Nombre del status de la tarea asignada" + "  " + Ta.Tarea);
                Console.WriteLine("");
            }
        
        }

        //hacemos un metodo donde el usuario pueda cambiar el status de la tarea 
        internal void CambiarStatus()
        {
            //hacemos un foreach para que haga lo mismo con todos los objetos en la lista
            foreach (Tareas Ta in lista)
            {
                //declaramos un valor donde se guardara el valor del nuevo status
                string newStat;
                //le pedimos al usuario que ingrese el nuevo status 
                Console.WriteLine("ingrese el nombre de la persona, para cambiar su Status:");
                newStat = Console.ReadLine();
                //hacemos un if para que solo cambie el status que pida el usuario
                if (newStat == Ta.Nombre)
                {

                    Console.WriteLine("");
                    Console.WriteLine("El estatus actual es" + "  " + Ta.Status);
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nuevo estatus:");
                    Ta.Status = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Ha cambiado el status a" + "  " + Ta.Status + "  " + "de la persona" + "  " + Ta.Nombre);
                    Console.ReadKey();
                    //un return para que no se repita el ciclo
                    return;
                }
            }
                  

        }

    }
}

