namespace GestaoDeEquipamentos2.ConsoleApp
{
   public static class Menu
    {
        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Gestão de Chamados");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==========================");
            Console.Write("Digite a opção desejada: ");
            return Console.ReadLine()![0];
        }
    }

}

