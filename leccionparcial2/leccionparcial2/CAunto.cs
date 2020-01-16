using System;
using System.Collections.Generic;
using System.Text;

namespace leccionparcial2
{
    class CAunto:IComponente
    {
        //Esta clase representa al componente y debe de implementar
        //a IComponentes para llevar a cabo la decoracion
        private string modelo;
        private string caracteristicas;
        public double costo;

        public CAunto(string pModelo, string pCaract, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCosto;
        }
        public void puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("puertas abiertas0");
        }
        public override string ToString()
        {
            return string.Format("Modelo{0},{1}\r\n", modelo, caracteristicas);
        }
        //Estos son los metodos implemeltados de IComponentes
        public double Costo()
        {
            return costo;
        }
        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
