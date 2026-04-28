// See https://aka.ms/new-console-template for more information
using System.Numerics;

float prova1, prova2, prova3, total;
Console.WriteLine("Digite a nota da prova1: ");
prova1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova2: ");
prova2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova3: ");
prova3 = float.Parse(Console.ReadLine());

total = (prova1 + prova2 + prova3);
Console.WriteLine("A media é: " + total);
