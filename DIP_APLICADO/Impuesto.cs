using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    abstract class Impuesto : IImprimir
    {
        //Propiedad de la clase Impuesto
        public double Importe { get; set; }

        //Cargamos el dato ingresado estáticamente "importe" en la propiedad de la clase
        public Impuesto(double importe)
        {
            Importe = importe;
        }

        //Implementación de la interfaz y se declara como abstracta porque las clases hijas son las que contienen el proceso de impresión
        public abstract void iImprimir();
    }
}
