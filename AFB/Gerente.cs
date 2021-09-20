namespace AFB
{
    public class Gerente : Funcionario, IJunior, IPleno
    {
        private Projeto[] projetos;

        public Gerente(string nome, string nivel, double salario, Projeto projeto) : base (nome, nivel, salario)
        {
            Projetos = new Projeto[1]{projeto};
        }

        public Projeto[] Projetos { get => projetos; set => projetos = value; }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
        public string ImprimirDados()
        {
            return $"{Nome}, {Nivel}, {Salario}, {Projetos[0]}";
        }
    }
}