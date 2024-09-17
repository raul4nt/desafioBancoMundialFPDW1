public class ContaSalario: Conta{
    
    public ContaSalario(Pessoa titular, long numero, int agencia, 
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
        if (contaDestino.Titular == Titular){
            if (Saldo >= valor){
                Saldo -= valor;
                contaDestino.Saldo += valor;
            }else{
                Console.WriteLine("Saldo insuficiente!");
            }
        }else{
            Console.WriteLine("Esta conta não é sua!");
        }

    }
}

// Conta Salário: O saldo não pode ficar negativo. Permite apenas operação de saque, consulta o valor do 
// Saldo e transferência para contas com mesmo títular e apenas 
// para uma conta em que o titular da conta seja o mesmo da conta salário. A Conta salário não possui taxas!