string nome;
float  p1, p2, p3;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota da prova de Português?");
p1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova de Matematica?");
p2 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Digite a nota da prova de Conhecimentos Gerais?");
p3 = float.Parse(Console.ReadLine());

if (p1 >= 7 && p2 >= 7 && p3 >= 7)
{
    Console.WriteLine(nome + " APROVADO =D ");
}

else if (p1 <= 5 && p2 <= 5 && p3 <= 5) ;
    {
        Console.WriteLine(nome + " REPROVADO =/ ");
    }
