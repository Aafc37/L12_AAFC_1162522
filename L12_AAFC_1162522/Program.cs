using System;

namespace LAB_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas escolares");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] notas;
            public int suma = 0;
            int prom = 15;
         
            public void Cargar()
            {
                notas  = new int[15];
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("Ingresa una nota: ");
                    string linea;
                    linea = Console.ReadLine();
                    notas[f] = int.Parse(linea);
                    suma = suma + notas [f];
                    

                }
            }
            public void Imprimir()
            {
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se registro ");
                    Console.WriteLine(notas[f]);
                }

                Console.WriteLine("La suma de las notas  es : " + suma);
                Console.WriteLine("La media  de las notas  es : " + suma/prom);
                Console.ReadKey();
            }

        }
    }
}