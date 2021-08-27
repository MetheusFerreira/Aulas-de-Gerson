using System;

class MainClass {
  public static void Main (string[] args) {
    IRacional humano = new SerHumano();
    humano.Falar();
    humano.Andar();
  }
}
