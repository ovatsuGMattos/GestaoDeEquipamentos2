﻿namespace GestaoDeEquipamentos2.ConsoleApp.Compartilhado;

public static class GeradorIds
{
    //• Deve ter um identificador único(Id);
    public static int IdChamados = 0;

    public static int GerarIdChamados()
    {
        return IdChamados++;
    }
}