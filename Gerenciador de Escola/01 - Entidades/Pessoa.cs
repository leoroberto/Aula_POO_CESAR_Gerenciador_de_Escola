namespace Gerenciador_de_Escola;

public class Pessoa
{
    public string nome { get; set; }
    public string email { get; set; }
    public string cpf { get; set; }
    public string telefone { get; set; }

    public Pessoa(string nome, string email, string cpf, string telefone)
    {
        this.nome = nome;
        this.email = email;
        this.cpf = cpf;
        this.telefone = telefone;
    }
}