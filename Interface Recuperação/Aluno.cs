using System;
class Aluno : Pessoa, IMultimidia, IProgramacao
{
    private string nome;
	private int idade;
	private string curso;

	public Aluno(string nome, int idade, string curso)
	{
		this.nome = nome;
		this.idade = idade;
		this.curso = curso;
	}

    public string Nome { get => nome; set => nome = value; }
	public int Idade { get => idade; set => idade = value; }
	public string Curso { get => curso; set => curso = value; }

    public void AulaNormal(){}
	public void AulaDesign(){}
	public void AulaCodigo(){}
	public override string Trabalhar()
	{
		return $"{nome}, {curso}, {idade}";
	}
}
