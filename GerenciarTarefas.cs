namespace GerenciarTarefas
{
    class Metodos
    {
        public static void Menu ()
        {
            // Lista de opções
            List<string> opcoes = new List<string>
            {
                "1. Adicionar Tarefa",
                "2. Listar Tarefas",
                "3. Concluir Tarefa",
                "4. Remover Tarefa",  // Adicionada vírgula
                "5. Sair"
            };

            int opcaoSelecionada;

            do
            {
                // Exibe as opções no console
                Console.Clear();
                Formatacao.Cor("Escolha uma opção: ", ConsoleColor.Blue);
                foreach (var opcao in opcoes)
                {
                    Console.WriteLine(opcao);
                }

                // Tenta obter a opção escolhida pelo usuário
                Console.Write("Digite o número da opção: ");
                bool entradaValida = int.TryParse(Console.ReadLine(), out opcaoSelecionada);

                if (entradaValida)
                {
                    switch (opcaoSelecionada)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu: Adicionar Tarefa.");
                            break; 
                        case 2:
                            Console.WriteLine("Você escolheu: Listar Tarefas.");
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu: Concluir Tarefa.");
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu: Remover Tarefa.");
                            break;
                        case 5:
                            Formatacao.Cor("Saindo...", ConsoleColor.Blue);
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida, por favor escolha uma opção válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida, por favor digite um número.");
                }

                // Pausa para o usuário ver a resposta
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcaoSelecionada != 5); // O loop continua até a opção "Sair" (opção 5)
        }
    }

    // Exemplo de classe Formatacao para mudar a cor do texto
    public static class Formatacao
    {
        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}