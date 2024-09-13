class PessoaJuridica : Pessoa{
    
    public List<PessoaJuridica> Socios { get; private set; }
    public int Cnpj{ get; set; }
    public string RazaoSocial{ get; set; }
    public string NomeFantasia{ get; set; }
    public int InscrEstadual{ get; set; }
    public DateTime DataAbertura{ get; set; }
    public  readonly int Idade;
    
    public double Faturamento{ get; set; }
    
    public PessoaJuridica(
         int numeroDePessoas, int id, string endereco, string tel, string email, List<PessoaJuridica> socios, 
         int cnpj, string razaoSocial, string nomeFantasia, int inscrEstadual,
         DateTime dataAbertura, int idade, double faturamento) : base(numeroDePessoas, id, endereco, tel, email){
            Socios = socios;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscrEstadual = inscrEstadual;
            DataAbertura = dataAbertura;
            Idade = idade; 
            Faturamento = faturamento;


         }

}