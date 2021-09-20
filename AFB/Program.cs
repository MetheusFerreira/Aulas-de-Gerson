using System;

namespace AFB
{
    class Program
    {
        static void Main(string[] args)
        {
            Projeto a = new Projeto("Mobile", 0);
            IPleno joao = new Gerente("João Gabriel", "Pleno", 2500, a);
            IJunior francisco = new Programador("Francisco", "Junior", 1500, 40);

            Console.WriteLine(joao.ImprimirDados());
            Console.WriteLine(francisco.ImprimirDados());
        }
    }
}
