namespace SistemaLogistica.Models;

public abstract class FuncionarioTransporte
{
    public string Nome { get; set; }
    public string Registro { get; set; }

    protected FuncionarioTransporte(string nome, string registro)
    {
        Nome = nome;
        Registro = registro;
    }

    public virtual void MostrarDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Registro: {Registro}");
    }
}