﻿class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+");
        }
    }
    public void ExibirMusica()
    {
        Console.WriteLine($"Esta é a Música {nome} do artista {artista}");
    }
}