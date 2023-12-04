using Linflez.Dtos;
using Linflez.Servicios;


namespace Linflez 
{
    /// <summary>
    /// Método principal de nuestra aplicación.
    /// lig - 041223
    /// </summary>

    public class Program {
        /// <summary>
        /// Clase principal de nuestra aplicación.
        /// lig - 021223
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            List<ElementoDto> list = new List<ElementoDto>(); 

            
            //objetos
            MenuInterfaz aka = new MenuImplementacion();
            ElementoInterfaz ao = new ElementoImplementacion();

            //variables
            int opcionSeleccionada;
            bool cerrarMenu = false;
    
            while(!cerrarMenu)
            {
                opcionSeleccionada = aka.mostrarMenu();

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Dar de alta un nuevo elemento:");
                        ao.seleccionarElemento();
                        break;
                    case 1:
                        Console.WriteLine("Dar de baja un elemento:");

                        break;
                    case 2:
                        Console.WriteLine("Eliminar cantidad de algún elemento:");
                       
                        break;
                    case 3:
                        Console.WriteLine("Cerrar Menú:");
                        cerrarMenu = true;
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no existe, escoja otra por favor:");
                       break;

                }
            }
        }
    }
}