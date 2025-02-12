namespace Tarefas
{
    class Tarefa
    {
        // Propriedade para armazenar o nome da tarefa
        public int Id { get; set; }
        // Propriedade para armazenar a descrição da tarefa
        public string Descricao { get; set; }
        public bool Concluido {get; set; }


        public Tarefa(int id,string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluido = false;
        }


        // Método para exibir a tarefa
        public void ExibirTarefa()
        {
            Console.WriteLine($"[{(Concluido ? "X" : " ")}] ID: {Id} - {Descricao}");
        }
    }
}
