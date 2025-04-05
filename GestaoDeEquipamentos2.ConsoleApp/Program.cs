namespace GestaoDeEquipamentos2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Controle de Chamados

            //• Deve ter o título do chamado;
            //• Deve ter a descrição do chamado;
            //• Deve ter um equipamento;
            //• Deve ter uma data de abertura;

            //Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar todos os chamados registrados para controle.
            //• Deve mostrar o título do chamado;
            //• Deve mostrar o equipamento;
            //• Deve mostrar a data de abertura;
            // Número de dias que o chamado está aberto

            //Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar um chamado que esteja registrado, sendo que ele possa editar todos os campos.
            //Requisito 2.4: Como funcionário Junior quer ter a possibilidade de excluir um chamado.
            static void Main(string[] args)
            {
                Chamado Chamado = new Chamado();

                bool opcaoSairEscolhida = false;

                while (!opcaoSairEscolhida)
                {
                    char opcaoPrincipalEscolhida = Menu.ApresentarMenuPrincipal();
                    char operacaoEscolhida;

                    switch (opcaoPrincipalEscolhida)
                    {
                        case '1':
                            operacaoEscolhida = telaEquipamento.ApresentarMenu();

                            if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                                break;

                            if (operacaoEscolhida == '1')
                                Chamado.CadastrarChamado();

                            else if (operacaoEscolhida == '2')
                                telaEquipamento.EditarEquipamento();

                            else if (operacaoEscolhida == '3')
                                telaEquipamento.ExcluirEquipamento();

                            else if (operacaoEscolhida == '4')
                                telaEquipamento.VisualizarEquipamentos(true);

                            break;

                        default: opcaoSairEscolhida = true; break;
                    }
                }

                Console.ReadLine();
            }



            Console.ReadLine();
        }
    }
}
