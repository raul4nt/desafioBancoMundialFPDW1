class PessoaJuridica : Pessoa{
    
    public List<PessoaFisica> Socios { get; private set; }
    public int Cnpj{ get; set; }
    public string RazaoSocial{ get; set; }
    public string NomeFantasia{ get; set; }
    public int InscrEstadual{ get; set; }
    public DateTime DataAbertura{ get; set; }
    public readonly int Idade;
    
    public double Faturamento{ get; set; }
    
    public PessoaJuridica(
         int id, string endereco, string tel, string email, List<PessoaFisica> socios, 
         int cnpj, string razaoSocial, string nomeFantasia, int inscrEstadual,
         DateTime dataAbertura) : base(id, endereco, tel, email){
            Socios = socios;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscrEstadual = inscrEstadual;
            DataAbertura = dataAbertura;
            Idade = Auxiliar.CalcularIdade(DataAbertura); 
            Faturamento = 0;


         }

}

// Pessoas jurídicas tem uma lista de sócios 
// composto por pessoas físicas, cnpj, razão
//  social, nome fantasia, Insc. Estadual e 
//  data abertura da empresa como campos 
//  obrigatórios. Já os campos Faturamento 
//  e Idade são automaticamente preenchidos.