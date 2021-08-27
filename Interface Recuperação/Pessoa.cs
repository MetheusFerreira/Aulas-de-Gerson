using System;
public abstract class Pessoa
{
	private string nome;
	private int idade;
	
	public string GetNome()
	{
		return this.nome;
	}
	public int GetIdade()
	{
		return this.idade;
	}
	public void SetNome(string uepa)
	{
		this.nome = uepa;
	}
	public void SetIdade(int ratinho)
	{
		this.idade = ratinho;
	}
	public abstract string Trabalhar();
}
