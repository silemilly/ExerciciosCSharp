// See https://aka.ms/new-console-template for more information

float valor1, valor2, valor3, valores;
Console.WriteLine("Digite o valor de 1:");
valor1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de 2:");
valor2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de 3:");
valor3 = float.Parse(Console.ReadLine());
valores = (valor1 + valor2 + valor3);

Console.WriteLine("Ordem crescente");
if (valor1 < valor2 && valor1 < valor3) ;
{
    Console.WriteLine(valor1);
} 
if (valor2 < valor1 && valor2 < valor3) ;
{
    Console.WriteLine(valor2);
}
if (valor3 < valor1 && valor3 < valor2) ;
{
    Console.WriteLine(valor3);
}
