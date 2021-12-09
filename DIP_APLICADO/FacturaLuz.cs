using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class FacturaLuz : Impuesto
    {
        //Propiedad de la clase FacturaLuz
        public string CodigoPago { get; set; }
        //Cargamos el dato ingresado estáticamente "codigoPago"en la propiedad de la clase
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }
        //Implementación de la interfaz mediante el polimorfismo en la clase abstracta impuesto
        public override void iImprimir() => Console.WriteLine($"\nIMPRIMIENDO Factura de luz con el código de pago N° {CodigoPago} e importe {Importe}");
    }
}
