    double salarioAtual, salarioComAumento, porcentagemAumento;

    Console.Write("Digite o valor do salário atual: ");
    salarioAtual = double.Parse(Console.ReadLine());

    Console.Write("Digite o valor do salário com aumento: ");
    salarioComAumento = double.Parse(Console.ReadLine());

if (salarioComAumento > salarioAtual)
{
    // calculo da porcentagem do quanto aumenta
    porcentagemAumento = ((salarioComAumento - salarioAtual) / salarioAtual) * 100;

    Console.WriteLine("A porcentagem de aumento foi de: {0}%", porcentagemAumento);
}
else
{
    Console.WriteLine("O salário com aumento deve ser maior que o salário atual.");
}