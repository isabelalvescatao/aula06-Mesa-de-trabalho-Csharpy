// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite quantos quilômetros foram percorrido ");

double quilometrosPercorridosPeloVeiculo = Convert.ToDouble(Console.ReadLine());

quilometrosPercorridosPeloVeiculo *= 0.621371;

Console.Write($"Seu veículo um total de {quilometrosPercorridosPeloVeiculo} milhas");
