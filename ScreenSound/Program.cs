Host host1 = new("Host 01");
Podcast podcast1 = new("Podcast 01", host1);
Episodio episodio1 = new(1, "Episodio 01", 126);
episodio1.AdicionarConvidados("Batati");
episodio1.AdicionarConvidados("Batata");
Console.WriteLine(episodio1.Resumo);
Episodio episodio2 = new(2, "Episodio 02", 93);
Episodio episodio3 = new(3, "Episodio 03", 154);
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.AdicionarEpisodio(episodio3);
podcast1.ExibirDetalhes();
/*Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Feet Don't Fail Me")
{
    Duracao = 342,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Fortress")
{
    Duracao = 327,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();*/