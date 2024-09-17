public class ContaPoupanca: Conta, IDepositavel{
    
    public ContaPoupanca(Pessoa titular, long numero, int agencia, 
    double saldo, double taxaSaque) : base(titular, numero, agencia, saldo, taxaSaque){
    }

  public override void Sacar(double valor){
    if (Saldo >= valor){
      Saldo -= valor;
      Console.WriteLine("Saque realizado com sucesso!");  
    }else{ 
      Console.WriteLine("Saldo insuficiente!");
    }
  }


    public override double ConsultarSaldo()
    {
        return Saldo;
    }

    public override void Transferir(Conta contaDestino, double valor)
    {
        if (Saldo >= valor){
            Saldo -= valor;
            contaDestino.Saldo += valor;
        }else{
            Console.WriteLine("Saldo insuficiente!");
        }

    }

    public void Depositar(double valor){
        Saldo += valor;
        Console.WriteLine("Déposito realizado com sucesso!");
    }

}

// Conta poupança: O saldo desse tipo de conta não pode ficar negativo. Há uma taxa de saque igual 
// para todas as contas desse tipo. São permitidas operação de saque, depósito, transferência e consulta de saldo