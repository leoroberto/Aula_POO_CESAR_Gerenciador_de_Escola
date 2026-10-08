namespace Gerenciador_de_Escola._03___Repositorio;

//Classe responsável em armazenar os alunos em memória
public class RepositorioAlunos
{
    private List<Aluno> listaAlunos = new List<Aluno>();
    
    //CREATE - Adicionar novo Aluno
    public void Adicionar(string nome, string curso, string email, int matricula)
    {
        var aluno = new Aluno(nome, curso, email, matricula);
        listaAlunos.Add(aluno);
    }
}