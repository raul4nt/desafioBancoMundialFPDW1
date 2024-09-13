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
        int numeroDePessoas, int id, string endereco, string tel, string email, string nome, string sobrenome, string rg, string cpf, DateTime dataNasc, int idade, string faixaEtaria, double renda) : base(numeroDePessoas, id, endereco, tel, email){
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            Cpf = cpf;
            DataNasc = dataNasc;
            Idade = idade;
            FaixaEtaria = faixaEtaria;
            Renda = renda;
        }
}

