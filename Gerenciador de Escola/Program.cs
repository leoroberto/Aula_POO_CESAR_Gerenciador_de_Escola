using Gerenciador_de_Escola._02___Servico;

namespace Gerenciador_de_Escola;

class Program
{
    static void Main(string[] args)
    {
        string opcao;
        ServicoAlunos servico = new ServicoAlunos();

        do
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Consultar Aluno");
            Console.WriteLine("3 - Deletar Aluno");
            Console.WriteLine("4 - Sair");
            Console.Write("\nEscolha uma opção: ");
            
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarAluno();
                    break;
                case "2":
                    ConsultarAluno();
                    break;
                case "3":
                    DeletarAluno();
                    break;
                case "4":
                    Console.WriteLine("\nSaindo do programa...");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Pressione ENTER para tentar novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (opcao != "4");

        void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
                    
            Console.WriteLine("Digite o Curso: ");
            string curso = Console.ReadLine();
                    
            Console.WriteLine("Digite o Email: ");
            string email = Console.ReadLine();
                    
            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
            
            string msgRetorno = servico.Adicionar(nome, curso, email, matricula);
            
            Console.WriteLine(msgRetorno);
        }
        
        static void ConsultarAluno()
        {
            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
        }
        
        static void DeletarAluno()
        {
            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
        }
    }
}