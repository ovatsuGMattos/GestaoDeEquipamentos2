namespace GestaoDeEquipamentos2.ConsoleApp
{
    public class TelaChamados
    {
        public Chamado[] chamado = new Chamado[100];
        public int contadorChamado;

        public string ApresentarChamado()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escolha opção desejada:");
            Console.WriteLine("1»Cadastrar novo chamado:");
            Console.WriteLine("2»Editar chamado:");
            Console.WriteLine("3»Excluir chamado:");
            Console.WriteLine("3»Visualizar chamados em aberto: ");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("Digite uma opção válida:");
            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }

        public void CadastrarChamado()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("Cadastrar novo chamado");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva o título do chamado:");
            string tituloChamado = Console.ReadLine()!;

            Console.WriteLine("Descreva o chamado");
            string descricao = Console.ReadLine()!;

            Console.WriteLine("Digite o nome do equipamento:");
            string equipamento = Console.ReadLine()!;

            Console.Write("Digite a data de abertura do chamado (dd/MM/yyyy) ");
            DateTime dataAbertura = Convert.ToDateTime(Console.ReadLine());

            Chamado Chamado = new Chamado(tituloChamado, descricao, equipamento, dataAbertura);
            Chamado.Id = GeradorIds.GerarIdChamados();

            chamado[contadorChamado++] = Chamado;

            Notificador.ExibirMensagem("O chamado foi aberto com sucesso!", ConsoleColor.Green);
        }
        public void EditarChamado()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("Editando novo chamado");
            Console.WriteLine("---------------------------------------");

            VisualizarChamado(false);

            Console.WriteLine("Digite o ID do chamado que deseja selecionar:");
            int IdChamados= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o Título do chamado");
            string tituloChamado = Console.ReadLine()!;

            Console.WriteLine("Descreva o chamado");
            string descricao = Console.ReadLine()!;

            Console.WriteLine("Digite o nome do equipamento:");
            string equipamento = Console.ReadLine()!;

            Console.Write("Digite a data de abertura do chamado (dd/MM/yyyy) ");
            DateTime dataAbertura = Convert.ToDateTime(Console.ReadLine());

            Chamado chamadoEditado = new Chamado(tituloChamado, descricao, equipamento, dataAbertura);
            Chamado.Id = GeradorIds.GerarIdChamados();

            bool conseguiuEditar = false;

            for (int i = 0; i < chamado.Length ; i++)
            {
                if (Chamado[i] = null) continue;
            }


        }

    }
}
