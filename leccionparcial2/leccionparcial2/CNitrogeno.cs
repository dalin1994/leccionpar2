using System;
using System.Collections.Generic;
using System.Text;

namespace leccionparcial2
{
    class CNitrogeno:IComponente
    {
        //variable de referencia hacia decoramos
        private IComponente decoramosA;

        public CNitrogeno(IComponente pComponentes)
        {
            decoramosA = pComponentes;

        }
        public override string ToString()
        {
            return "Sistema de nitrogeno \r\n" + decoramosA.ToString();
        }
        //metodo de interfas
        public double Costo()
        {
            //Calcilamos el costo
            //el costo de lo que decoramos mas mi costo como componentes
            return decoramosA.Costo() + 45000;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ",Nitrogeno losto";
        }
        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
