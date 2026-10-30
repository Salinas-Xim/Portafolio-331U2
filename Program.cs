using System;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesión 13: Iteradores
            //Ximena Salinas Mendiola 331-34
            double z  = 0.63; //zancadas
            int c = 0; //cantidad  de zancadas
            double r = 0; //circuito (21km)
            int hidratacion = 2000; //cada cuanto se hidrata
            int t = 0; //numero de la pausa
            while(r <= 21000)
            {
                r = r + z;
                c = c + 1; 
                if(r >= hidratacion)
                {
                    t ++;
                    //Console.WriteLine($"Pausa en: {hidratacion}\n hidratación: {t}");
                    hidratacion += 2000;
                }
            }
           // Console.WriteLine($"Diana termino en: {c} zancadas.");
            /*
            1. Ciclo for
            Sintaxis: ciclo for
            for(inicialización; expresión; iterador)
            {
                //Bloque de intrucciones
            }
            */
            //Ejemplo: Secuencia 35-41
            for(int m = 35; m <= 41; m ++)
            {
                Console.WriteLine($"m: {m}");
            }
            //1. Definir un ciclo for para la siguiente secuencia: -33 -334 -35 -36 -37 -38 -39
            Console.WriteLine("Ciclos 1: Descendente");
            for(int p = -33; p >= -39; p --)
            {
                Console.WriteLine($"p: {p*-1}");
            }
            Console.WriteLine("Ciclo2: Ascendente");
            for (int a = 9; a <= 15; a ++)
            { 
                if(a != 13)
                {
                    Console.WriteLine($"a: {a}");
                }
            }
            
            for (int g = 1; g <= 539; g += 88)
            {
                Console.WriteLine($"Capítulo en pagina s{g}");
            }
        }
    }
}