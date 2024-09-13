public class ContaPoupanca: Conta{
    
    public ContaPoupanca(Pessoa titular, long numero, int agencia, 
    double saldo, double taxaSaque) : base(titular, numero, agencia, saldo, taxaSaque){
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