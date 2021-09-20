namespace AFB
{
    public class Programador : Funcionario, IJunior, IPleno
    {
        private int cargaHoraria;

        public Programador(string nome, string nivel, double salario, int cargaHoraria) : base (nome, nivel, salario)
        {
            this.CargaHoraria = cargaHoraria;
        }

        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public override void AumentarSalario()
        {
            this.Salario *= 1.2;
        }
        
        public string ImprimirDados()
        {
            return $"{Nome}, {Nivel}, {Salario}, {CargaHoraria}h";
        }
    }
}