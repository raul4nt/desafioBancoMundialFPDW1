public class ContaCorrente: Conta, IDepositavel{
    public  readonly TipoConta Tipo;
    
    public readonly double Limite;

    public readonly double TaxaDoLimite;
    

    public ContaCorrente(Pessoa titular, long numero, int agencia, 
    double saldo, double taxaSaque, TipoConta tipo, double limite, double taxaDoLimite) : base(titular, numero, agencia, saldo, taxaSaque){
        
         if (tipo == TipoConta.ESPECIAL)
        {
            double rendaOuFaturamento = 0;
            
            if (titular is PessoaFisica pf)
            {
                rendaOuFaturamento = pf.Renda;
            }
            else if (titular is PessoaJuridica pj)
            {
                rendaOuFaturamento = pj.Faturamento;
            }

            if (rendaOuFaturamento <= 5000.00)
            {
                throw new ArgumentException("Contas do tipo 'ESPECIAL' só podem ser abertas para pessoas com renda superior a R$ 5.000,00.");
            }
        }

        
        Tipo = tipo;
        Limite = limite;
        TaxaDoLimite = taxaDoLimite;
        

    }

    public enum TipoConta{
        
        SIMPLES,
        ESPECIAL,
    }



    public override void Sacar(double valor)
    {
        throw new NotImplementedException();
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
}



// ContaCorrente: O atributo TipoConta pode ter o valor: SIMPLES ou ESPECIAL. 
// Contas do tipo especial podem apenas ser abertas para pessoas físicas ou 
// jurídicas com renda/faturamento superior à R$ 5.000,00. Toda conta corrente
//  pode ficar com o saldo negativo, mas não pode ultrapassar o limite. O limite
//   é calculado com base na renda, sendo 150% da renda para contas simples e 
//   250% da renda para conta especial. A taxa de juros do limite da conta corrente
//    é de 5% para contas simples e 2% para contas especiais.

// A conta corrente permite operações de saque, depósito, transferência, 
// pagamentos, consulta de saldo e empréstimos. 