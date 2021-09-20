namespace AFB
{
    public class Projeto
    {
        private double valor;
        private string nome;

        public double Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }

        public Projeto(string nome, double valor){}
    }
}