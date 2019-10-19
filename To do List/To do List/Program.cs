using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //en el main solo instanciamos la clase repo y llamamos al metodo bienvenida y al menu
            Repotarea rt = new Repotarea();
            rt.Bienvenida();
            rt.Menu();
        }
    }
}
