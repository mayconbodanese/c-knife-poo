class Carro
{
    public string placa;
    public int velocidade;
    public string buzina;

    public void Acelerar()
    {
        velocidade += 10;
        Console.WriteLine($"Velocidade atual de: {velocidade}");
    }

    public void Frear()
    {
        velocidade = 0;
        Console.WriteLine($"O carro parou");
    }

    public void Buzinar()
    {
        Console.WriteLine(buzina);
    }
}