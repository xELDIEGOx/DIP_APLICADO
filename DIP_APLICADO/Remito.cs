using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class Remito : IImprimir
    {
        //Propiedades de la clase Remito
        public int Num { get; set; }
        public DateTime Fecha { get; set; }
        public double CantBultos { get; set; }

        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase
        public Remito(int num, DateTime fecha, int cantBultos)
        {
            Num = num;
            Fecha = fecha;
            CantBultos = cantBultos;
        }

        //Implementa la interfaz iImprimir para realizar el proceso de la impresora
        public void iImprimir() => Console.WriteLine($"\nIMPRIMIENDO recibo remito {Num} del {Fecha} con una cantidad de bultos igual a {CantBultos}");
    }
}
