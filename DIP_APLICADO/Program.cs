using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los objetos e inicializamos con datos estáticos para cada clase  (Factura,NotaCredito,Remito,FacturaLuz,Municipal)

            Factura factura = new Factura(2002, DateTime.Now, 3030.520);
            NotaCredito notaCredito = new NotaCredito(111, DateTime.Now, 256.01);
            Remito remito = new Remito(223, DateTime.Now, 334);
            FacturaLuz facturaLuz = new FacturaLuz(445, "codigoPago001");
            Municipal municipal = new Municipal(556, "partida66778899");

            //Tambien podemos crear un objeto de tipo IImprimible pero que solo contenga el método imprimir, por ejemplo:
                 IImprimir facturaa = new Factura(2002, DateTime.Now, 3030.520000000111000);
                 facturaa.iImprimir();
                 Console.WriteLine("\n*****Facturas con implementación el patrón de diseño Inversión de dependencias*****\n\n");

            //Creamos el objeto de la clase impresora e imprimimos por medio de la intefaz
            Impresora impresora = new Impresora();
            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);

            //También podemos implementar lo que es una lista respecto a la interfaz IImpresora
            Console.WriteLine("\nImpresiones por medio de Lista");
            List<IImprimir> ListaImpresion = new List<IImprimir>();
            ListaImpresion.Add(factura);
            ListaImpresion.Add(notaCredito);
            ListaImpresion.Add(remito);
            ListaImpresion.Add(facturaLuz);
            ListaImpresion.Add(municipal);

            foreach (var item in ListaImpresion)
            {
                impresora.Imprimir(item);
            }

            Console.Read();
        }
    }
}
