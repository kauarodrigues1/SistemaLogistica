using SistemaLogistica.Models;

Console.WriteLine("=== SISTEMA DE LOGÍSTICA ===");
Console.WriteLine();

MotoristaCarreta motorista = new MotoristaCarreta(
    "Carlos Silva",
    "FUN001",
    "ABC1D23"
);

EntregadorMoto entregador = new EntregadorMoto(
    "Ana Souza",
    "FUN002",
    "A"
);

List<FuncionarioTransporte> funcionarios = new List<FuncionarioTransporte>
{
    motorista,
    entregador
};

foreach (FuncionarioTransporte funcionario in funcionarios)
{
    funcionario.MostrarDetalhes();
    Console.WriteLine();
}

Console.WriteLine("Pressione ENTER para encerrar.");
Console.ReadLine();