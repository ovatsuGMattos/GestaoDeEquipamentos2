namespace GestaoDeEquipamentos2.ConsoleApp
{
    public static class Menu
    {
        public static char ApresentarMenuPrincipal()
        {
            ExibirCabecalho();

            Console.WriteLine("1 - Gerência de Chamados");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()![0];

            return opcaoEscolhida;
        }

        public static void ExibirCabecalho()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|        Gestão de Chamados            |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
        }
    }
}
}
