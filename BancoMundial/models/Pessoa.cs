public abstract class Pessoa{
    
    public static int NumeroDePessoas { get; private set; } = 0;
    public int Id{ get; set; }
    public string Endereco{ get; set; }
    public string Tel{ get; set; }
    public string Email{ get; set; }

    public Pessoa(int id, string endereco, string tel, string email){
        Id = id;
        Endereco = endereco; 
        Tel = tel; 
        Email = email;
        NumeroDePessoas++;

    }
}


// Todos os clientes do banco tem um id, 
// um endereço, um número de telefone e 
// um e-mail para contato, sendo todos 
// esses dados obrigatórios na hora do 
// cadastro. Sendo que é possível 
// SOMENTE cadastrar dois tipos de Clientes: 
// Pessoas Físicas e Pessoas Jurídicas.