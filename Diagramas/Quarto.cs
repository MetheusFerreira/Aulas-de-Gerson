public class Quarto
{
    private PortaQuarto porta;
    private bool banheiro;
    private float metragemQuadrada;

    public bool Banheiro { get => banheiro; set => banheiro = value; }
    public float MetragemQuadrada { get => metragemQuadrada; set => metragemQuadrada = value; }
    public PortaQuarto Porta { get => porta; set => porta = value; }

    public Quarto()
    {
        this.Porta = new PortaQuarto();
    }
}
