public class ContaPoupanca : Conta
{
    public ContaPoupanca(string nome, int nConta) : base (nome,nConta){}
	public void AdicionarRendimento(double jurosTaxa){
		Creditar((jurosTaxa*Saldo)/100);
	}
}
