public class Sala
{
    private PortaSala portaEntrada;
    private float metragemQuadrada;
    private Porta portaAuxiliar;

    public PortaSala PortaEntrada { get => portaEntrada; set => portaEntrada = value; }
    public float MetragemQuadrada { get => metragemQuadrada; set => metragemQuadrada = value; }
    public Porta PortaAuxiliar { get => portaAuxiliar; set => portaAuxiliar = value; }

    public Sala()
    {
        this.PortaEntrada = new PortaSala();
    }
}
