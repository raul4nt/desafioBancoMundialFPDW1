public class ContaCorrente: Conta, IDepositavel{
    public  readonly TipoConta Tipo;
    
    public readonly double Limite;

    public readonly double TaxaDoLimite;
    

    public ContaCorrente(Pessoa titular, long numero, int agencia, 
    double saldo, double taxaSaque, TipoConta tipo) : base(titular, numero, agencia, saldo, taxaSaque){
        
         double rendaOuFaturamento = 0;

         if (titular is PessoaFisica pf){
            rendaOuFaturamento = pf.Renda;
         
         } else if (titular is PessoaJuridica pj){
            rendaOuFaturamento = pj.Faturamento;
         }

         if (tipo == TipoConta.ESPECIAL){
            
            if (rendaOuFaturamento <= 5000.00) {
                throw new ArgumentException("Contas do tipo 'ESPECIAL' só podem ser abertas para pessoas com renda superior a R$ 5.000,00.");
         }
            Limite = rendaOuFaturamento * 2.5;
            TaxaDoLimite = 0.02;
            
        } else{
            Limite = rendaOuFaturamento * 1.5;
            TaxaDoLimite = 0.05;
        }
        
        Tipo = tipo;
        
    }

    public enum TipoConta{
        
        SIMPLES,
        ESPECIAL,
    }



    public override void Sacar(double valor) {
        double saldoDisponivel = Saldo + Limite;

        if (valor <= saldoDisponivel) {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        } else {
            Console.WriteLine("Saldo insuficiente! O valor excede o limite disponível.");
        }
    }

    public override double ConsultarSaldo()
    {
        return Saldo;
    }

    public override void Transferir(Conta contaDestino, double valor)
    {
        //Corrigir
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

    public void Pagar(string codigoBarras){
        Console.WriteLine("Código de barras pago!");
    }

    public void Emprestimo(double valor){
        Console.WriteLine($"Empréstimo no valor de R${valor} realizado!");
    }

}



// ContaCorrente: O atributo TipoConta pode ter o valor: SIMPLES ou ESPECIAL. 
// Contas do tipo especial podem apenas ser abertas para pessoas físicas ou 
// jurídicas com renda/faturamento superior à R$ 5.000,00. 


// Toda conta corrente pode ficar com o saldo negativo, mas não pode ultrapassar o limite. 



//   O limite é calculado com base na renda, sendo 150% da renda para contas simples e 
//   250% da renda para conta especial. A taxa de juros do limite da conta corrente
//    é de 5% para contas simples e 2% para contas especiais.






// A conta corrente permite operações de saque, depósito, transferência, 
// pagamentos, consulta de saldo e empréstimos. 