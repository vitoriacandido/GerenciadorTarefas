namespace Layout
{
    class Formataçao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
    }

    public static string ImprimirCabecalho()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("        GERENCIADOR DE TAREFAS        ");
        Console.WriteLine("==============================================");

        Console.WriteLine("1 - Adicionar Tarefa");
        Console.WriteLine("2 - Listar Tarefas");
        Console.WriteLine("3 - Concluir Tarefa");
        Console.WriteLine("4 - Remover Tarefa");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();
        return opcao;
    }

    internal static void Cor()
    {
        throw new NotImplementedException();
    }
}