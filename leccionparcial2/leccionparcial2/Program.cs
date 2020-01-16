using System;

namespace leccionparcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el componente central con tipo IComponente
            //para permitir la decoracion
            IComponente miAuto = new CAunto("2018", "4 puetas", 200000);

            Console.WriteLine(miAuto);

            //si necesitamos usar un metodo propio de CAunto
            //necesitamos hacer uso de un type cast
            ((CAunto)miAuto).puertas(true);

            Console.WriteLine("--------------");
            ////decoramos el auto con un sistema de sonido
            miAuto = new CSistemaSonido(miAuto);

            //commprovamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------------");

            miAuto = new CNitrogeno(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------------");

            //para usar algio propio del nitrogeno necesitamos un type cast
            ((CNitrogeno)miAuto).UsaN();

            Console.WriteLine("------------------");
            miAuto = new CSuspension(miAuto);


            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------------");

            //ojo , no usar metodos espesificos una vez que decoramos 
            //sobre ella

            //((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAunto).Puerta(false);
        }
    }
    
}
