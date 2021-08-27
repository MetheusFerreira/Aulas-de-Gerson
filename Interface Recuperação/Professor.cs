using System;
public class Professor: Pessoa,IMultimidia,IProgramacao
{
	private string nome;
	private int idade;
	private string disciplina;

	public Professor(string nome, int idade, string disciplina)
	{
		this.Nome = nome;	
		this.Idade = idade;
		this.Disciplina = disciplina;
	}

	public string Nome { get => nome; set => nome = value; }
	public int Idade { get => idade; set => idade = value; }
	public string Disciplina { get => disciplina; set => disciplina = value; }

	public void AulaCodigo(){}

	public void AulaDesign(){}

	public void AulaNormal(){}

	public override string Trabalhar()
	{
			return $"{nome}, {disciplina}, {idade}";
	}
}
