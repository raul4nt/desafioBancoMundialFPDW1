public class ContaCorrente: Conta{
    public  readonly string Tipo;
    
    public readonly double Limite;

    public readonly double TaxaDoLimite;
    

    public ContaCorrente(Pessoa titular, long numero, int agencia, 
    double saldo, double taxaSaque, string tipo, double limite, double taxaDoLimite) : base(titular, numero, agencia, saldo, taxaSaque){
        Tipo = tipo;
        Limite = limite;
        TaxaDoLimite = taxaDoLimite;
    }

    public override void Sacar(double valor)
    {
        throw new NotImplementedException();
    }

    public override double ConsultarSaldo()
    {
        throw new NotImplementedException();
    }

    public override void Transferir(Conta conta, double valor)
    {
        throw new NotImplementedException();
    }
}