// See https://aka.ms/new-console-template for more information
float nota1, nota2, nota3, total;
string nome;
Console.WriteLine("Digite o numero A: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero B: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero C: ");
nota3 = float.Parse(Console.ReadLine());

if (nota1 + nota2 >= nota3) ;
{
    Console.WriteLine("A soma de A + B é maior ou igual a C");
}
if (nota1 + nota3 >= nota2) ;
{
    Console.WriteLine("A soma de A + C é maior ou igual a B");
}
if (nota2 + nota3 >= nota1) ;
{
    Console.WriteLine("A soma de B + C é maior ou igual a A");
}
