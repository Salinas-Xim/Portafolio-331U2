using System;
namespace Cs7
{
    class Program
    {
        //función  principal
        static void Main(string[] args)
        {
            //Sesión 15: Funciones
            /*
            Función: Bloque de instrucciones para realizar una tarea especifica, únicamente, cuando es invocado
            Sintaxis
            tipo_dato_devuelto identificador_función(párametros)
            {
                Bloque de instrucciones
            }
            NOTA: Los párametros de definen incluyendo el tipo de dato.
            NOTA 2: Loa párametros van separados por comas
            
            Sintaxis: Invocación función
            identificador_función(argumentos);
            */
            //Ejemplo 1: Función vacía sin párametros
            //Definición
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"Hola, {salón}");
            }
            //Invocación
            Saludar();
            //Ejercitación
            //1. definir e invocar una función sin parámetros para imprimir: nombre, clave y salón.
            void invoc()
            {
                string Nombre = "Ximena";
                string clave = "34";
                string salón = "331";
                Console.WriteLine($"{Nombre}, {salón}-{clave}");
            }
            invoc();
            //2. definir e invocar una función para desplegar el horario de hoy
            void horaro();
            {
               Console.WriteLine($"1.Calculo ");
               Console.WriteLine($"2. Formación Humana");
               Console.WriteLine($"3. Programación");
               Console.WriteLine($"4. Psicología");
               Console.WriteLine($"5. Portugués");
               Console.WriteLine($"Dibujo Técnico");
               Console.WriteLine($"Dibujo Técnico");
            }
            horaro();
        }//Termino de la Funcion principal
    }//
}//
