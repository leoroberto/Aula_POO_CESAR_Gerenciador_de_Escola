using Gerenciador_de_Escola._03___Repositorio;

namespace Gerenciador_de_Escola._02___Servico;

public class ServicoAlunos
{
    private RepositorioAlunos repositorio = new RepositorioAlunos();

    public ServicoAlunos()
    {
        
    }

    public string Adicionar(string nome, string email, string telefone, string cpf, string curso, int matricula)
    {
        repositorio.Adicionar(nome, email, telefone, cpf, curso, matricula);
        return $"Aluno '{nome}' cadastrado com sucesso!\n";
    }

    public string Consultar(int matricula)
    {
        Aluno alunoConsultado = repositorio.Consultar(matricula);
        
        if (alunoConsultado != null)
        {
            return $"Matrícula: '{alunoConsultado.matricula}', Nome: {alunoConsultado.nome}";
        }
        else
        {
            return "Aluno não encontrado";
        }
        
    }

    public string Deletar(int matricula)
    {
        bool alunoDeletado = repositorio.Deletar(matricula);

        if (alunoDeletado)
        {
            return "Aluno deletado com sucesso";
        }

        return "Aluno não encontrado";
    }
}