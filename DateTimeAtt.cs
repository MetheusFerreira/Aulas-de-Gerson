using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Digite sua data de nascimento no formato americano eca");
    DateTime data = DateTime.Parse(Console.ReadLine());
    DateTime agora = DateTime.Now;
    TimeSpan dif = agora - data;
    Console.WriteLine($"Você tem entre {agora.Year - data.Year} e {agora.Year - data.Year - 1} anos de idade.");
    Console.WriteLine("Já vivesses " + dif.ToString("dd") + " dias.");
    Console.WriteLine("Já vivesses " + dif.TotalHours + " horas.");
  }
}
