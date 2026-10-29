namespace Gerenciador_de_Escola;

public class Aluno : Pessoa
{
    public int matricula { get; set; }
    public string curso { get; set; }
    
    public Aluno(string nome, string email, string telefone, string cpf, string curso, int matricula) 
        : base(nome, email, cpf, telefone)
    {
        this.curso = curso;
        this.matricula = matricula;
    }
}