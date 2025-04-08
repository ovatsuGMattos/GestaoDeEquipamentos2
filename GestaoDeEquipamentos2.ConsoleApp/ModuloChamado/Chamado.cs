namespace GestaoDeEquipamentos2.ConsoleApp.ModuloChamado
{
    public class Chamado
    {
        public int Id { get; set; }
        public string TituloChamado { get; set; }
        public string Descricao { get; set; }
        public string Equipamento { get; set; }
        public DateTime DataAbertura { get; set; }

        public int DiasAberto => (DateTime.Now - DataAbertura).Days;

        public Chamado(string titulo, string descricao, string equipamento, DateTime dataAbertura)
        {
            TituloChamado = titulo;
            Descricao = descricao;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }
        public void Exibir()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {TituloChamado}");
            Console.WriteLine($"Equipamento: {Equipamento}");
            Console.WriteLine($"Data de Abertura: {DataAbertura:dd/MM/yyyy}");
            Console.WriteLine($"Dias em Aberto: {DiasAberto}");
            Console.WriteLine("---------------------------------------");
        }
    }
}
