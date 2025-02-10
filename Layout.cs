namespace Layout
{
    class Formatacao
    {
       public static void Cor(string mensagem,ConsoleColor cor)
        {
            
            Console.ForegroundColor = cor;
            Console.Write(ImprimirCabecario);
            Console.ResetColor();
        }
    }
}