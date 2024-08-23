class Carro
{
    public string? Fabricante { get; set; }
    public string? Modelo { get; set; }
    public int Ano 
    { 
        get { return Ano; } 
        set {
            if (Ano > 1960 && Ano < 2023)
            {
                Ano = Ano;
            } else {
                throw new ArgumentOutOfRangeException("Ano", "O ano deve estar entre 1960 e 2023.");
            }
        } 
    }
    public int Velocidade { get; set; }
    public string? Buzina { get; set; }
    public string DescricaoDetalhada 
    {
        get { return $"Fabricante: {Fabricante} Modelo: {Modelo} Ano: {Ano}"; }
    }


    public void Acelerar()
    {
        Velocidade += 10;
        Console.WriteLine($"Velocidade atual de: {Velocidade}");
    }

    public void Frear()
    {
        Velocidade = 0;
        Console.WriteLine($"O carro parou");
    }

    public void Buzinar()
    {
        Console.WriteLine(Buzina);
    }
}