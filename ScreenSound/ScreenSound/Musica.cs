class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+");
        }
    }

    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    public bool LeDisponivel()
    {
        return disponivel;
    }
    public void ExibirMusica()
    {
        Console.WriteLine($"Esta é a Música {nome} do artista {artista}");
    }
}