using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linflez.Dtos
{
    /// <summary>
    /// Método que contiene la clase elemento.
    /// lig - 041223
    /// </summary>
    internal class ElementoDto
    {
        //atributos
           
        long idElemento = 0;//64
        string codigoElemento= "aaaaa";
        string nombreElemento = "aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento = 0;//32

        //get y set
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //constructores 
        public ElementoDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento) 
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }
        public ElementoDto() 
        {
        }
        //toString
        override
            public string ToString()
        {
            string datos = "idElemento" + idElemento + "codigoElemento" + codigoElemento + "nombreElemento" + nombreElemento + "descripcionElemento" + descripcionElemento + "cantidadElemento"+ cantidadElemento;


            return datos;

        }





    }
}
