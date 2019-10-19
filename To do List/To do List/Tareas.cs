using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List
{
    public class Tareas
    {
        //encapsulamos los datos de que debe de llevar los objetos
        public string Nombre { get; set; }
        public string Tarea { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }

    }
}
