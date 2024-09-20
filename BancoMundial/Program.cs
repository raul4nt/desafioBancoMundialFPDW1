using System;
using System.Collections.Generic;

class Program {
    public static void Main (string[] args) {
        
        // Testando Pessoa Física
        PessoaFisica pf = new PessoaFisica(1, "Rua A", "555-1234", "pf@email.com", "João", "Silva", "123456789", "11122233344", new DateTime(1990, 5, 15), 8000);
        Console.WriteLine($"Pessoa Física: {pf.Nome} {pf.Sobrenome}, Idade: {pf.Idade}, Faixa Etária: {pf.FaixaEtaria}, Renda: {pf.Renda}");
        
        // Testando Pessoa Jurídica
        List<PessoaFisica> socios = new List<PessoaFisica> { pf };
        PessoaJuridica pj = new PessoaJuridica(2, "Rua B", "555-4321", "pj@email.com", socios, 12345678, "Empresa X", "Fantasia Y", 987654321, new DateTime(2005, 1, 10), 10000);
        Console.WriteLine($"Pessoa Jurídica: {pj.RazaoSocial}, Idade: {pj.Idade}, Faturamento: {pj.Faturamento}");

        // Testando Conta Corrente (Pessoa Física)
        ContaCorrente contaCorrentePf = new ContaCorrente(pf, 1001, 1234, 0, 5.0, ContaCorrente.TipoConta.ESPECIAL);
        contaCorrentePf.Depositar(1000);
        Console.WriteLine($"Conta Corrente (PF) - Saldo: {contaCorrentePf.ConsultarSaldo()}");

        // Testando Conta Poupança (Pessoa Física)
        ContaPoupanca contaPoupanca = new ContaPoupanca(pf, 1002, 1235, 0, 2.5);
        contaPoupanca.Depositar(500);
        Console.WriteLine($"Conta Poupança - Saldo: {contaPoupanca.ConsultarSaldo()}");
        
        // Testando saque na Conta Poupança
        contaPoupanca.Sacar(100);
        Console.WriteLine($"Conta Poupança - Saldo após saque: {contaPoupanca.ConsultarSaldo()}");

        // Testando Conta Salário (Pessoa Física)
        ContaSalario contaSalario = new ContaSalario(pf, 1003, 1236, 0, 0);
        

        // Testando Transferência
        contaCorrentePf.Transferir(contaPoupanca, 200);
        Console.WriteLine($"Conta Corrente (PF) - Saldo após transferência: {contaCorrentePf.ConsultarSaldo()}");
        Console.WriteLine($"Conta Poupança - Saldo após receber transferência: {contaPoupanca.ConsultarSaldo()}");

        // Testando Pessoa Jurídica com Conta Corrente
        PessoaJuridica empresa = new PessoaJuridica(3, "Rua C", "555-5678", "empresa@email.com", new List<PessoaFisica>(), 12345678, "Tech Solutions", "Tech Sol", 99887766, new DateTime(2010, 6, 5));
        ContaCorrente contaEmpresa = new ContaCorrente(empresa, 1004, 1237, 0, 5.0, ContaCorrente.TipoConta.SIMPLES);
        contaEmpresa.Depositar(10000);
        Console.WriteLine($"Conta Corrente (PJ) - Saldo: {contaEmpresa.ConsultarSaldo()}");

        // Testando saque na Conta Corrente
        contaCorrentePf.Sacar(1500);
        Console.WriteLine($"Conta Corrente (PF) - Saldo após saque: {contaCorrentePf.ConsultarSaldo()}");

        // Testando saque no limite (Conta Corrente Especial)
        contaCorrentePf.Sacar(3700);
        Console.WriteLine($"Conta Corrente (PF) - Saldo após usar limite: {contaCorrentePf.ConsultarSaldo()}");

        // Testando Pagar boleto
        contaCorrentePf.Pagar("12345678901234567890123456789012345678901234");


        // IMPORTANTE: fiz todos os testes usando faturamento/renda acima do Tipo de Conta Especial(renda mínima superior a 5000)
        // PORÉM, é só tirar o último atributo de pf ou pj(renda) que a renda default vai ser setada como 0, e vai gerar uma ArgumentException
        // -> Isso porque se a renda for abaixo de 5001, a pessoa ou empresa NÃO pode ter uma conta especial. 
    }
}
