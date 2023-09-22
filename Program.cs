// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Custos de energia");

double consumo, horasedia;
decimal custos, estimativa;

Console.Write("Consumo do aparelho (em kWh/mês): ");
consumo = Convert.ToDouble(Console.ReadLine());

Console.Write("Horas de uso por dia: ");
horasedia = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo da energia (em R$/kWh): ");
custos = Convert.ToDecimal(Console.ReadLine());

estimativa=Convert.ToDecimal(consumo * horasedia) * custos;

Console.WriteLine($"Custo estimado: {estimativa}");