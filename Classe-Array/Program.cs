Console.WriteLine("=== Classe Array ===");

string[] nomes = new string[5] { "Nicolas", "Miranda", "Leo", "Ale", "Wally" };
Console.WriteLine("\n\nExibindo o Array original.");

ExibirArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do Array");

Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando o Array");

Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um nome");
Console.Write("Informe um nome: ");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if (indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado no indice = {indice}");
}
else
{
    Console.WriteLine($"{nome} não foi encontrado");
}

static void ExibirArray(string[] nomes)
    {
        foreach (var nome in nomes)
        {
            Console.Write($"{nome} ");
        }
    }