using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linflez.Servicios
{
    /// <summary>
    /// Método que muestra la interfaz del menú de los elementos de la implementación.
    /// lig - 041223
    /// </summary>
    internal interface ElementoInterfaz
    {
        /// <summary>
        /// Método que implementa la selección del método.
        /// lig - 041223
        /// </summary>
        public void seleccionarElemento();
        /// <summary>
        /// Método que da el alta al elemento
        /// lig - 041223
        /// </summary>
        /// <param name="ListaAntigua"></param>
        public void altaElemento(List<ElementoImplementacion> ListaAntigua);
        /// <summary>
        /// Método que da la baja al elemento
        /// lig - 041223
        /// </summary>
        /// <param name="ListaAntigua"></param>
        public void bajaElemento(List<ElementoImplementacion> ListaAntigua);
      
    }
}
