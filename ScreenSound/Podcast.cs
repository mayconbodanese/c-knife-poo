class Podcast
{
    private readonly List<Episodio> episodios = new();
    public Podcast(string nome, Host host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public Host Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} por {Host.Nome}");
        foreach (Episodio episodio in episodios.OrderBy(episodio => episodio.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Episodios Total: {TotalEpisodios}");
    }
}