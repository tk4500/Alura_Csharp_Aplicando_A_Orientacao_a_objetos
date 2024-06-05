﻿using System.Collections.Concurrent;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista da Música do álbum {Nome} :\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música : {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir o álbum inteiro você precisa de {DuracaoTotal} segundos");

    }
}