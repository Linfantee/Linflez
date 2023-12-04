using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linflez.Servicios
{
    /// <summary>
    /// Método que muestra por pantalla la implementación de los elementos para que el usuario los introduzca
    /// lig - 041223
    /// </summary>
    internal class ElementoImplementacion : ElementoInterfaz
    {

        public void seleccionarElemento() 
        {

            long idElemento;//64
            string codigoElemento;
            string nombreElemento;
            string descripcionElemento;
            int cantidadElemento;//32

            Console.WriteLine("Introduzca un id de tipo entero(números): ");
            idElemento = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca un nombre de tipo texto(letras): ");
            nombreElemento = Console.ReadLine();

            Console.WriteLine("Introduzca una descripción de tipo texto(letras): ");
            descripcionElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad del elemento en tipo entero(número): ");
            cantidadElemento = Convert.ToInt32(Console.ReadLine());

        }
        public void altaElemento(List<ElementoImplementacion> ListaAntigua)
        {
         

        }
        public void bajaElemento(List<ElementoImplementacion > ListaAntigua)
        {
            int valorDado;
            int solucion;
            Console.WriteLine("Introduzca el codigo del elemento");
            string codigoEl2 = Console.ReadLine();
             
            foreach(ElementoImplementacion opcionSeleccionada in ListaAntigua)
            {
                if (codigoEl2.Equals(opcionSeleccionada))
                {
                    Console.WriteLine("");
                    valorDado = Convert.ToInt32(Console.ReadLine());

                }


            }
        }





    }
}
