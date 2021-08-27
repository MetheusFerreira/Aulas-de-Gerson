using System;

class MainClass {
  public static void Main (string[] args) {
    ContaPoupanca c1 = new ContaPoupanca("Maria Fernanda", 1234);
    ContaCorrente c2 = new ContaCorrente("Paulo Ricardo", 1235);

	c2.Creditar(100);
    c1.Creditar(250);
    c1.AdicionarRendimento(5);
    c2.CobrarTaxa(1);

    Console.WriteLine(c1.Saldo);
    Console.WriteLine(c2.Saldo);
  }
}
