class ContaBancaria
{
    public int NumeroIndicador { get; }
    public string Titular { get; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($@"
        Titular: {Titular}
        Saldo: {Saldo}
    ");
    }
}