using GestaoDeEquipamentos2.ConsoleApp.Compartilhado;
using GestaoDeEquipamentos2.ConsoleApp.ModuloChamado;

namespace GestaoDeEquipamentos2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                TelaChamados telaChamados = new TelaChamados();
                bool opcaoSairEscolhida = false;

                while (!opcaoSairEscolhida)
                {
                    char opcaoPrincipalEscolhida = Menu.ApresentarMenuPrincipal();

                    switch (opcaoPrincipalEscolhida)
                    {
                        case '1':
                            string opcao = telaChamados.ApresentarChamado();

                            switch (opcao)
                            {
                                case "1": telaChamados.CadastrarChamado(); break;
                                case "2": telaChamados.EditarChamado(); break;
                                case "3": telaChamados.ExcluirChamado(); break;
                                case "4": telaChamados.VisualizarChamado(true); break;
                                default: Console.WriteLine("Opção inválida."); break;
                            }
                            break;

                        case '0':
                            opcaoSairEscolhida = true;
                            break;
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                }
            }
        }
    }
}
