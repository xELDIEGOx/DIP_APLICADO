using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_APLICADO
{
    class Municipal : Impuesto
    {
        //Propiedad de la clase Municipal
        public string Partida { get; set; }
        //Cargamos el dato ingresado estáticamente "Partida" en la propiedad de la clase
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        //Implementación de la interfaz mediante el polimorfismo en la clase abstrastracta impuesto
        public override void iImprimir() => Console.WriteLine($"\nIMPRIMIENDO impuesto municipal de partida {Partida} por un importe {Importe}");
    }
}
