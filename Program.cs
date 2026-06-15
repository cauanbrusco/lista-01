Console.Write("Informe a idade do passageiro: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Informe o valor normal da passagem: ");
double valor = double.Parse(Console.ReadLine());

double pagar;

if (idade <= 5)
{
    pagar = 0;
}
else if (idade >= 60)
{
    pagar = valor / 2;
}
else
{
    pagar = valor;
}

Console.WriteLine($"Valor normal da passagem: R$ {valor:F2}");
Console.WriteLine($"Valor a pagar: R$ {pagar:F2}");
