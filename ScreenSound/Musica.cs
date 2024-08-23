class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";


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