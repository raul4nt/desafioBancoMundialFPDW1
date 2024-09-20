public abstract class Conta{
    public Pessoa Titular{ get; set; }
    public long Numero{ get; set; }
    public int Agencia{ get; set; }
    public double Saldo{ get; set; }
    public double TaxaSaque{ get; set; }

    public Conta(Pessoa titular, long numero, int agencia, double saldo, double taxaSaque){
        Titular = titular; 
        Numero = numero;
        Agencia = agencia;
        Saldo = 0;
        TaxaSaque = taxaSaque;
    
    }

    public abstract void Sacar(double valor);
    public abstract double ConsultarSaldo();
    public abstract void Transferir(Conta conta, double valor);
    

}


// Toda Conta aberta no banco deve ter um títular, que pode ser tanto uma pessoa 
// física quanto uma pessoa jurídica. 
// Além do número da conta e agência e uma taxa de saque. O saldo é definido 
// como zero, sempre que uma conta for aberta. 