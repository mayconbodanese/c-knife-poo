class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(@$"
            Nome:               {nome}
            Artista:            {artista}
            Duração:            {duracao}

                    {(disponivel ? "Disponível" : "Indisponivel")}
        ");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($@"
            Nome:               {nome}
            Artista:            {artista}
        ");
    }
}