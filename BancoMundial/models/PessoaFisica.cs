class PessoaFisica : Pessoa{
    public string Nome{ get; set; }
    public string Sobrenome{ get; set; }
    public string Rg{ get; set; }
    public string Cpf{ get; set; }
    public DateTime DataNasc{ get; set; }
    public  readonly int Idade;
   
    public  readonly string FaixaEtaria;
    public double Renda{ get; set; }

    public PessoaFisica(
        int id, string endereco, string tel, string email, string nome, string sobrenome, string rg, string cpf, DateTime dataNasc) : base(id, endereco, tel, email){
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            Cpf = cpf;
            DataNasc = dataNasc;
            Idade = Auxiliar.CalcularIdade(DataNasc);
            FaixaEtaria = Auxiliar.FaixaEtaria(Idade);
            Renda = 0;
        }
}

// Pessoas físicas tem um nome, sobrenome, rg, 
// cpf e data de nascimento como campos obrigatórios. 
// Os campos idade, faixa etária e renda são definidos 
// automaticamente.
