namespace GestaoDeEquipamentos2.ConsoleApp
{
    public class TelaChamados
    {
        private Chamado[] chamados = new Chamado[100];
        private int contadorChamado = 0;

        public string ApresentarChamado()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escolha opção desejada:");
            Console.WriteLine("1»Cadastrar novo chamado");
            Console.WriteLine("2»Editar chamado");
            Console.WriteLine("3»Excluir chamado");
            Console.WriteLine("4»Visualizar chamados em aberto");
            Console.WriteLine("---------------------------------------");

            Console.Write("Digite uma opção válida: ");
            return Console.ReadLine()!;
        }

        public void CadastrarChamado()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar novo chamado");
            Console.WriteLine("---------------------------------------");

            Console.Write("Título: ");
            string titulo = Console.ReadLine()!;

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine()!;

            Console.Write("Equipamento: ");
            string equipamento = Console.ReadLine()!;

            Console.Write("Data de Abertura (dd/MM/yyyy): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Chamado novoChamado = new Chamado(titulo, descricao, equipamento, data);
            novoChamado.Id = GeradorIds.GerarIdChamados();

            chamados[contadorChamado++] = novoChamado;

            Notificador.ExibirMensagem("Chamado cadastrado com sucesso!", ConsoleColor.Green);
        }
        public void EditarChamado()
        {
            Console.Clear();
            Console.WriteLine("Editar chamado");
            VisualizarChamado(false);

            Console.Write("ID do chamado: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Chamado? selecionado = null;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null && chamados[i].Id == idSelecionado)
                {
                    selecionado = chamados[i];
                    break;
                }
            }
            if (selecionado == null)
            {
                Notificador.ExibirMensagem("Chamado não encontrado.", ConsoleColor.Red);
                return;
            }

            Console.Write("Novo Título: ");
            selecionado.TituloChamado = Console.ReadLine()!;

            Console.Write("Nova Descrição: ");
            selecionado.Descricao = Console.ReadLine()!;

            Console.Write("Novo Equipamento: ");
            selecionado.Equipamento = Console.ReadLine()!;

            Console.Write("Nova Data de Abertura: ");
            selecionado.DataAbertura = Convert.ToDateTime(Console.ReadLine()!);

            Notificador.ExibirMensagem("Chamado editado com sucesso!", ConsoleColor.Green);
        }
        public void ExcluirChamado()
        {
            Console.Clear();
            VisualizarChamado(false);

            Console.Write("ID do chamado para excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null && chamados[i].Id == idSelecionado)
                {
                    chamados[i] = null;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Notificador.ExibirMensagem("Chamado excluído com sucesso!", ConsoleColor.Green);
            else
                Notificador.ExibirMensagem("Chamado não encontrado.", ConsoleColor.Red);
        }
        public void VisualizarChamado(bool exibirCabecalho)
        {
            if (exibirCabecalho)
            {
                Console.Clear();
                Console.WriteLine("Chamados em Aberto:");
                Console.WriteLine("---------------------------------------");
            }

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null)
                    chamados[i].Exibir();
            }
        }
    }
}