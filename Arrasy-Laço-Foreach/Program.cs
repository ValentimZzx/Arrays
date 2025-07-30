using Microsoft.Win32.SafeHandles;

Console.WriteLine("=== Acessando um laço foreach no Array ===");



int[] numeros;

numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

string[] nomes = new string[5] { "Carlos", "Maira", "Osvaldo", "Nay", "Nicolas" };

foreach (var numero in numeros)
{
    Console.Write($"{numero} ");
}

foreach (var nome in nomes)
{
    Console.Write($"{nome} ");
}