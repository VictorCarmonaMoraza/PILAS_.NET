using System;
using System.Collections;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PILAS
            string palabras;
            int numeroDeElementos;
            Stack elementosPila;

            //Usando PUSH y POP
            //Push ---->Apilar
            //POP  ---->Desapilar
            Console.ForegroundColor = ConsoleColor.Green;
            elementosPila = new Stack();
            elementosPila.Push("Hola");
            elementosPila.Push("Tu");
            elementosPila.Push("eres");
            elementosPila.Push("Victor");

            //Contamos los elementos de la pila
            numeroDeElementos = elementosPila.Count;

            //Pintamos los elementos de la pila en pantalla
            Console.WriteLine($"Hay {numeroDeElementos} elementos en la pila");

            //Recorremos nuestra pila
            for (int i = 0; i < numeroDeElementos; i++)
            {
                //Desapilamos os elementos de la pila
                palabras = (string)elementosPila.Pop();
                //Imprimimos los elementos de la pila
                Console.WriteLine($"Pop: {palabras}");
            }
            Console.ReadKey();

            //Usando PEEK  -->Muestra los elementos que tiene la pila sin extraerlo
            Console.ForegroundColor = ConsoleColor.Red;
            elementosPila.Push("Victor");
            elementosPila.Push("eres");
            elementosPila.Push("genial");

            numeroDeElementos = elementosPila.Count;
            for (int i = 0; i < numeroDeElementos; i++)
            {
                palabras = (string)elementosPila.Peek();
                //Imprimimos los elementos de la pila
                Console.WriteLine($"Siguiente palabra en la pila: {palabras}");

                palabras = (string)elementosPila.Pop();
                //Imprimimos los elementos de la pila
                Console.WriteLine($"Pop: {palabras}");

            }
            Console.ReadKey();


            //Usando Contains y Clear
            Console.ForegroundColor = ConsoleColor.Yellow;
            elementosPila.Push("Victor");
            elementosPila.Push("eres");
            elementosPila.Push("genial");

            //si nuestra pila contiene el elemento Victor limpiamos la pila
            if (elementosPila.Contains("Victor"))
            {
                elementosPila.Clear();
            }
            Console.WriteLine($"La pila contiene {elementosPila.Count} despues de ejecutar el metodo Clear");
            Console.ReadKey();
        }
    }
}
