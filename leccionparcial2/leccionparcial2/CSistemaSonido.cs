using System;
using System.Collections.Generic;
using System.Text;

namespace leccionparcial2
{
    class CSistemaSonido:IComponente
    {
        //variables de referencia hasia quien decoramos
        private IComponente decoramosA;
        public CSistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }
        public override string ToString()
        {
            return "Radio 360yz+\r\n" + decoramosA.ToString();
        }
        //metodos de la interfaz
        public double Costo()
        {
            //calculamos el costo
            //el costo de lo que decoramos mas mi costo como componente.
            return decoramosA.Costo() + 3500;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ",Ensendemos el radio";
        }
    }
}
