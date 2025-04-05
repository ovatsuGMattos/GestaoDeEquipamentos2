namespace GestaoDeEquipamentos2.ConsoleApp
{
    public class Chamado
    {
        public int Id { get; set; }
        public string TituloChamado { get; set; }
        public string Descricao {  get; set; }
        public string Equipamento { get; set; }
        public DateTime DataAbertura {  get; set; }


        public Chamado(string tituloChamado, string descricao, string equipamento, DateTime dataAbertura)
        {
            TituloChamado = tituloChamado;
            Descricao = descricao;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }
        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = TituloChamado.Substring(0, 3).ToUpper();

            return ($"{tresPrimeirosCaracteres}-{Id}");
        }


    }
}
