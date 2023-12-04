using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linflez.Servicios
{
    /// <summary>
    /// Método que muestra por pantalla el menú para la elección del usuario.
    /// lig - 041223
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int mostrarMenu;

            Console.WriteLine("-------------------");
            Console.WriteLine("0. Dar de alta a un elemento");
            Console.WriteLine("1. Dar de baja a un elemento");
            Console.WriteLine("2. Eliminar un elemento");
            Console.WriteLine("3. Cerrar el menú");
            Console.WriteLine("-------------------");
            mostrarMenu = Console.ReadKey(true).KeyChar - ('0');

            return mostrarMenu;
        }


    }
}
