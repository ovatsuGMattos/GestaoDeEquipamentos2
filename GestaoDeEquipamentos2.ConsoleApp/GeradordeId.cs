namespace GestaoDeEquipamentos.ConsoleApp;

public static class GeradorIds
{

    //• Deve ter um identificador único(Id);
    public static int IdChamados = 0;

    public static int GerarIdChamados()
    {
        IdChamados++;

        return IdChamados;
    }

    public static Guid GerarGuidChamado()
    {
        return Guid.NewGuid();
    }
}