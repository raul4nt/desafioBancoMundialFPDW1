public class Auxiliar{

    public static int CalcularIdade(DateTime DataNasc){
        var hoje = DateTime.Today;
        var idade = hoje.Year - DataNasc.Year;
        if (DataNasc > hoje.AddYears(-idade)) idade--;
        return idade;
    }

public static string FaixaEtaria(int idade)
{
    if (idade <= 11)
    {
        return "criança";
    }
    else if (idade >= 12 && idade <= 21)
    {
        return "jovem";
    }
    else if (idade >= 22 && idade <= 59)
    {
        return "adulto";
    }
    else if (idade >= 60)
    {
        return "idoso";
    }
    else
    {
        return "idade inválida";
    }
}

    
}