using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            pilha.Push (3);
            pilha.Push(12);
            fila.Enqueue(5);
            fila.Enqueue(8);
            int x = pilha.Pop();
            pilha.Push(2);
            fila.Enqueue(x);
            pilha.Push(x); 

            //Console.WriteLine(pilha.Count);
            //Console.WriteLine(fila.Count);

            foreach (int pilhas in pilha)
            {
                Console.WriteLine(pilhas);
            }

            Console.WriteLine("só os bunitin");

            foreach(int filas in fila)
            {
                Console.WriteLine(filas);
            }
        }
    }
}
