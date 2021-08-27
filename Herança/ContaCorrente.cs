public class ContaCorrente : Conta
{	
    public ContaCorrente(string nome, int nConta): base (nome,nConta){}
	public void CobrarTaxa(double jurosTaxa){
		Debitar((jurosTaxa*Saldo)/100);
	}
}
