class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {get;}
public Banda Artista {get;}
public int Duracao {get; set;}
public bool Disponivel {get; set;}
public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

public void ExibirFichaTecnnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista; {Artista.Nome}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            System.Console.WriteLine("Disponivel no plano");
        } else
        {
            System.Console.WriteLine("Adquira o plano basico");
        }
    
    }
}




