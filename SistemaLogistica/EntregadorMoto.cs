namespace SistemaLogistica.Models;

public class EntregadorMoto : FuncionarioTransporte
{
    public string CategoriaCNH { get; set; }

    public EntregadorMoto(string nome, string registro, string categoriaCNH)
        : base(nome, registro)
    {
        CategoriaCNH = categoriaCNH;
    }

    public override void MostrarDetalhes()
    {
        Console.WriteLine("=== Entregador de Moto ===");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Registro: {Registro}");
        Console.WriteLine($"Categoria da CNH: {CategoriaCNH}");
    }
}