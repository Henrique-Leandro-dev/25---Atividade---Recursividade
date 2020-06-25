using System;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            System.Console.WriteLine("Sequência Fibonacci");
            fibo.GerarSequenciaFibonacci(0,1,13);
            System.Console.WriteLine("Sequência fatorial");
            System.Console.WriteLine(fibo.GerarFatorial(8));
        }
    }
}
