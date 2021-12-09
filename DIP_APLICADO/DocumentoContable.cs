using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    public abstract class DocumentoContable : IImprimir
    {
        //Propiedades de la clase DocumentoContable
        public int Num { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }

        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase 
        public DocumentoContable(int num, DateTime fecha, double importe)
        {
            Num = num;
            Fecha = fecha;
            Importe = importe;
        }

        //Creación de polimorfismo para sobreescribir el método Total en las clases hijas
        public abstract double Total();

        //Implementación de la interfaz y se declara como abstracta porque las clases hijas son las que contienen el proceso de impresión
        public abstract void iImprimir();
    }
}
