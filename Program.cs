decimal valorHoraBase;
decimal totalHorasTrabalhadas;
decimal totalHorasExtras;
decimal salarioBase;
decimal valorHoraExtra;
decimal totalHoraExtra;
decimal salarioFinal;

Console.Clear();

Console.WriteLine("Digite o valor do salário por hora:");
valorHoraBase = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite o total de horas trabalhadas:");
totalHorasTrabalhadas = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite o total de horas extras trabalhadas:");
totalHorasExtras = Convert.ToDecimal(Console.ReadLine()!);

CalcularSalario(valorHoraBase, totalHorasTrabalhadas, totalHorasExtras);

Console.Clear();

Console.WriteLine("--- Salário ---\n");

Console.Write("Valor por hora: ");
Console.WriteLine($"{valorHoraBase:C2}");

Console.Write("Horas trabalhadas: ");
Console.WriteLine($"{totalHorasTrabalhadas}h");

Console.Write("Valor adicional por hora extra (40%): ");
Console.WriteLine($"{valorHoraExtra:C2}");

Console.Write("Total de horas extras: ");
Console.WriteLine($"{totalHorasExtras}h");

Console.WriteLine();

Console.Write("Salário final: ");
Console.WriteLine($"{salarioFinal:C2}");

decimal CalcularSalario(decimal valorHora, decimal horasNormais, decimal horasExtras)
{
    salarioBase = valorHora * horasNormais;

    valorHoraExtra = valorHora * 0.40m;

    totalHoraExtra = valorHoraExtra * horasExtras;

    salarioFinal = salarioBase + totalHoraExtra;

    return salarioFinal;
}