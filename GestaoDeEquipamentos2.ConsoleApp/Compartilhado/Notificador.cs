namespace GestaoDeEquipamentos2.ConsoleApp.Compartilhado
{
    public static class Notificador
    {
        public static void ExibirMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
