using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Helper
    {
        public Helper()
        {
        }

        public string mensajeDeCompra()
        {
            return "¡Gracias por su compra! Ha hecho muy felíz a algúna persona en algún lugar";
        }

        /*Intente centralizar el método de cargarImagen porque lo llamaba de dos ventanas diferentes,
        pero no supe solucionar el problema de como especificar en qué picture box se debía cargar la imágen.
        Busqué info en la documentación y tutoriales pero no di con la solución. Aún así quise hacer la clase Helper
        y usarla con algún método como para demostrar que entiendo que hay funciones que puedo centralizar si debo invocarlas
        de distintos lugares. El mensajito de compra lo inventé sobre la marcha para poder poner en práctica ese concepto*/
    }
}
