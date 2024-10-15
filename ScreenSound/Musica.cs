class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(@$"
            Nome:               {Nome}
            Artista:            {Artista}
            Duração:            {Duracao}
                    {(Disponivel ? "Disponível" : "Indisponivel")}
            Descrição:          {DescricaoResumida}
        ");
    }
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($@"
            Nome:               {Nome}
            Artista:            {Artista}
        ");
    }
}