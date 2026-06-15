Console.Write("Informe a quantidade de clientes atendidos: ");
int clientes = int.Parse(Console.ReadLine());

double total = 0;

for (int i = 1; i <= clientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    double tempo = double.Parse(Console.ReadLine());

    total += tempo;
}

double media = total / clientes;

Console.WriteLine($"Tempo total de atendimento: {total} minutos");
Console.WriteLine($"Tempo médio por cliente: {media} minutos");
