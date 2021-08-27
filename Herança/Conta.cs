public class Conta
{
	private string nome;
	private int nConta;
	private double saldo;

	public string Nome{ get => nome;private set => nome = value;}
    public int NConta{ get => nConta;private set => nConta = value;}
    public double Saldo{ get => saldo;private set => saldo = value;}
	
	public Conta(string nome, int nConta)
	{
		this.Nome = nome;
		this.NConta = nConta;
	}
	public void Debitar(double valor){
  	this.Saldo -= valor;
  }
    public void Creditar(double valor){
    this.Saldo += valor;
  }
}
