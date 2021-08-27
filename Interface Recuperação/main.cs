using System;

class MainClass {
  static void Main(string[] args)
	{
		IMultimidia atumalaca = new Aluno("João Gabriel",14,"UI/UX Design");
		IProgramacao peludao = new Professor("Francisco", 32,"Lógica de Programação");
		Console.WriteLine(atumalaca.Trabalhar());
		Console.WriteLine(peludao.Trabalhar());
	}
}
