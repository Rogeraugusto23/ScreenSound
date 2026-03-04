Episodio ep1 = new(1, "Tecnica de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
System.Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Tecnica de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

//Banda queen = new Banda("Queen");
//
//
//Album albumDoQueen = new Album("A night at the opera");
//
//
//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};
//
//
//
//Musica musica2 = new Musica(queen, "Bohemian")
//{
//    Duracao = 354,
//    Disponivel = false,
//};
//
//
//
//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);
//
//
//musica1.ExibirFichaTecnnica();
//musica2.ExibirFichaTecnnica();
//albumDoQueen.ExibirMusicaDoAlbum();
//queen.ExibirDiscografia();
