namespace Tarefas
{
    class Tarefa
    {
        // Propriedade para armazenar o nome da tarefa
        public string Nome { get; set; }
        
        // Propriedade para armazenar a descrição da tarefa
        public string Descricao { get; set; }

        // Método para exibir a tarefa
        public void ExibirTarefa()
        {
            Console.WriteLine($"Tarefa: {Nome}");
            Console.WriteLine($"Descrição: {Descricao}");
        }
    }
}
