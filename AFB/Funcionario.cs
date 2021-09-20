namespace AFB
{
    public abstract class Funcionario
    {
        private string nome;
        private string nivel;
        private double salario;

        public Funcionario(string nome, string nivel, double salario)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.salario = salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public double Salario { get => salario; set => salario = value; }
        public abstract void AumentarSalario();
    }
}