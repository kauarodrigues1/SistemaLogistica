namespace SistemaLogistica.Models;

public class MotoristaCarreta : FuncionarioTransporte
{
    public string Placa { get; set; }

    public MotoristaCarreta(string nome, string registro, string placa)
        : base(nome, registro)
    {
        Placa = placa;
    }

    public override void MostrarDetalhes()
    {
        Console.WriteLine("=== Motorista de Carreta ===");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Registro: {Registro}");
        Console.WriteLine($"Placa: {Placa}");
    }
}