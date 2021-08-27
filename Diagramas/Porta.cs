public class Porta
{
    private string cor;
    private float largura;
    private float altura;
    private double peso;

    public Porta(){}
    public string Cor { get => cor; set => cor = value; }
    public float Largura { get => largura; set => largura = value; }
    public float Altura { get => altura; set => altura = value; }
    public double Peso { get => peso; set => peso = value; }

    public void Abrir(){}
    public void Fechar(){}
}
