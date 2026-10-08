namespace Gerenciador_de_Escola;

public class Aluno
{
    public int matricula { get; set; }
    public string nome { get; set; }
    public string curso { get; set; }
    public string email { get; set; }
    
    public Aluno(string nome, string curso, string email, int matricula)
    {
        this.nome = nome;
        this.curso = curso;
        this.email = email;
        this.matricula = matricula;
    }
}