using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class ReciboSueldo : IImprimir
    {
        //Propiedades de la clase ReciboSueldo
        public double Total { get; set; }
        public int Legajo { get; set; }

        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

        //Implementa la interfaz iImprimir para realizar el proceso de la impresora
        public void iImprimir() => Console.WriteLine($"\nIMPRIMIENDO recibo de sueldo del legajo {Legajo} con un total de {Total}");
    }
}
