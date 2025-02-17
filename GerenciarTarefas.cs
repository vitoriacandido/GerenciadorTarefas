namespace GerenciarTarefas
{
    using Tarefas;

    public class Metodos
    {
        static List<Tarefa> tarefas = new List<Tarefa>();
        static int contadorId = 1;

        public static void Menu()
        {
            int opcaoSelecionada;

            do
            {
                Console.Clear();
                Layout.Formatacao.ImprimirCabecalho();

                // Exibe as opções no menu
                opcaoSelecionada = int.Parse(Console.ReadLine());

                switch (opcaoSelecionada)
                {
                    case 1:
                        AdicionarTarefa();
                        break;
                    case 2:
                        ListarTarefas();
                        break;
                    case 3:
                        ConcluirTarefa();
                        break;
                    case 4:
                        RemoverTarefa();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcaoSelecionada != 0); // O loop continua até a opção "Sair"
        }

        private static void AdicionarTarefa()
        {
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();
            tarefas.Add(new Tarefa(contadorId++, descricao));
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        private static void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas cadastradas.");
            }
            else
            {
                foreach (var tarefa in tarefas)
                {
                    tarefa.ExibirTarefa();
                }
            }
        }

        private static void ConcluirTarefa()
        {
            Console.Write("Digite o ID da tarefa a ser concluída: ");
            int id = int.Parse(Console.ReadLine());
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                tarefa.Concluido = true;
                Console.WriteLine("Tarefa concluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        private static void RemoverTarefa()
        {
            Console.Write("Digite o ID da tarefa a ser removida: ");
            int id = int.Parse(Console.ReadLine());
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
}
