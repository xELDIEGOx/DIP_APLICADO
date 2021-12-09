using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class Impresora
    {
        //Maneja todos los procesos de impresión de las diferentes clases, recibiendo un objeto desde la clase program
        public void Imprimir(IImprimir iimprimir)
        {
            iimprimir.iImprimir();
        }
    }
}
