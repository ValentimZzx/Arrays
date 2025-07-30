//Crie um programa em C# que receba via teclado o nome de 5 alunos
//armazene os nomes em um array chamado "nomes", e, a seguir os
//receboa também via teclado a nota, como um double, dos 5 alunos
//e aramezene os valores em um array chamado notas.

//A seguir realize as seguintes operações:

//Acessa e exibir no console os nomes do alunos armazenados no array
//nomes.
//Acessar e exibir no console as notas dos alunos armazenadas no array notas.
//Calcular a média artimética das notas e exibir no console o valor obtido.

Console.WriteLine("=== Arrays Exercios ===");

//definir os arrays
string[] nomes = new string[5];
double[] notas = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe a nota do Aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

foreach (string nome in nomes)
{
    Console.WriteLine($"{nome} ");
}

var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach (double nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"{nota} ");
}

Console.WriteLine($"\nMédia artimética: \n {somaNotas / totalNotas}");

Console.ReadKey();