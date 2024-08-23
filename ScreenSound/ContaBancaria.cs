class ContaBancaria
{
    public int numeroIndicador;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($@"
        Titular: {titular}
        Saldo: {saldo}
    ");
    }
}