using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List
{ 
    //hacemos herencia 
    public class Repotarea:DatosTarea
    {
        //instanciamos la Lista para que se pueda usar en los case
        List<Tareas> lista = new List<Tareas>();
        //Le damos la bienvenida al usuario para caerles mejor
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a la Lista de tareas");
            Console.ReadKey();
        }
        //hacemos un metodo que muestre el menu que se le desplegara al usuario donde observe sus opciones
        public void Menu()
        {
            //Hacemos el menu
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("1.-Crear tarea \n2.-Lista de tareas \n3.-Detalles de Tarea\n4.-Status de tareas\n5.-Cambiar Status de una Tarea\n6.-Salir del programa");
            DatosTarea Tar = new DatosTarea();
            //hacemos un switch para que los numeros que ingrese el usuario tengan sentido
            switch (Console.ReadLine())
            {
                case "1":
                    //llamamos al metodo gettareas para que el usuario pueda ingresar los datos de  las tareas
                    GetTareas();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                case "2":
                    //llamamos al metodo Listadetareas para que el usuario pueda ver solo las tareas asignadas y a quien estan asignadas 
                    Listadetareas();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                case "3":
                    //Llamamos al metodo Detallesdetareas para que el usuario pueda ver todos los detalles de las tareas
                    DetallesDeTareas();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                case "4":
                    //llamamos al metodo ListadeStatus para que el usuario pueda ver el status actual de las tareas y a quien esta asignadas
                    ListaDeEstatus();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "5":
                    //llamamos al metodo cambiarstatus para que el usuario pueda actualizar el status de una de las tareas especificas 
                    CambiarStatus();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "6":
                    //hacemos un case para que el usuario pueda salir del progama y al mismo tiempo darle las gracias por tomarse el tiempo de usar el progama
                    Console.WriteLine("Gracias por usar la lista de tareas ");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    //un case donde se le pida al usuario que ingrese el numero correcto 
                    Console.WriteLine("Ingrese un numero correcto");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

    }
}
    