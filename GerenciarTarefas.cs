namespace GerenciarTarefa
{
    // Classe GerenciarTarefa
    public class GerenciarTarefa
    {
        private List<Tarefas.Tarefa> tarefas;

        public GerenciarTarefa()
        {
            tarefas = new List<Tarefas.Tarefa>();
        }

        public void AdicionarTarefa(string descricao)
        {
            int id = tarefas.Count + 1;
            Tarefas.Tarefa novaTarefa = new Tarefas.Tarefa(id, descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine($"Tarefa '{descricao}' adicionada com sucesso.");
        }

        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
                Console.WriteLine("----------------------------");
            }
        }

        public void ConcluirTarefa(int id)
        {
            Tarefas.Tarefa tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluido = true;
                Console.WriteLine($"Tarefa ID {id} concluída com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o ID {id} não encontrada.");
            }
        }

        public void RemoverTarefa(int id)
        {
            Tarefas.Tarefa tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine($"Tarefa ID {id} removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o ID {id} não encontrada.");
            }
        }
    }

    // Classe Program com o ponto de entrada
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância do gerenciador de tarefas
            GerenciarTarefa gerenciar = new GerenciarTarefa();
            bool sair = false;

            // Loop principal do programa
            while (!sair)
            {
                // Exibe o cabeçalho e captura a opção do usuário
                string opcao = Layout.Formatacao.ImprimirCabecalho();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite a descrição da tarefa:");
                        string descricao = Console.ReadLine();
                        gerenciar.AdicionarTarefa(descricao);
                        break;

                    case "2":
                        gerenciar.ListarTarefas();
                        break;

                    case "3":
                        Console.WriteLine("Digite o ID da tarefa a ser concluída:");
                        int idConcluir = int.Parse(Console.ReadLine());
                        gerenciar.ConcluirTarefa(idConcluir);
                        break;

                    case "4":
                        Console.WriteLine("Digite o ID da tarefa a ser removida:");
                        int idRemover = int.Parse(Console.ReadLine());
                        gerenciar.RemoverTarefa(idRemover);
                        break;

                    case "0":
                        sair = true;
                        Layout.Formatacao.Cor("Saindo do Gerenciador de Tarefas...\n", ConsoleColor.Red);
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                // Pausa para que o usuário veja a saída antes de limpar a tela
                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
