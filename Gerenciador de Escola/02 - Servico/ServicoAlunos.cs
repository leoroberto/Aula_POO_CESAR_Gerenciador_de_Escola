using Gerenciador_de_Escola._03___Repositorio;

namespace Gerenciador_de_Escola._02___Servico;

public class ServicoAlunos
{
    private RepositorioAlunos repositorio;

    public ServicoAlunos()
    {
        repositorio = new RepositorioAlunos();
    }

    public string Adicionar(string nome, string curso, string email, int matricula)
    {
        repositorio.Adicionar(nome, curso, email, matricula);
        return $"✓ Aluno '{nome}' cadastrado com sucesso!\n";
    }
}