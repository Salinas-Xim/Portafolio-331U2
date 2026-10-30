using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30/09/2026
            //Sintaxis: while
            //inicialización;
            //while(expresión)
            //{
            //      Bloque de intstrucciones
            //      iterador;
            //}
            //Iterar: repetir
            //Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; //Inicialización
            while(m <= 3)//Expresión
            {
                //Bloque de instrucciones
            Console.WriteLine($"m: {m}");
             m += 1;
              }
            //Ejercitación
            //Definir un ciclo para imprimir tu nombre 5 veces 
            //Nota: Para la expresión utiizar la expresión <.
            int a = 1;
            while(a < 6)
            {
                Console.WriteLine($"Ximena Salinas Mendiola");
                a += 1;
            }
            //b. Ciclo descendente
            int d = 3;
            while (d <= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            //c. Incrementos 
            // Secuencia: 3 6 9 12 15 18
            int g = 3;
            while(g <= 18)
            {
                Console.WriteLine($"g: {g}");
                g += 3;
            }
            // d. Decrementos
            //1.Definir un ciclo paraimprimir "331" 8 veces.
            //Nota para la solucion define un
            int h = 16;
            while(h <= 0)
            {
                Console.WriteLine($"331");
                h -= 2;
            }
            //Actividad 1: Ciclo infinito
            //1. definir un ciclo infinito ascendente.
            //2. Definir un ciclo infinito descendente.
            //Nota. Para la solución, utilizar el operador de diferencia (solo 2).
            //1.
            int f = 3;
            while(f > 1)
            {
                f += 2;
            }
            //2.
            int v = 9;
            while(v != 10)
            {
                v -= 1;
            }
       }
    }
}