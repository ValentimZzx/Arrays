Console.WriteLine("=== Arrays ===\n");

//Declaração do Array
int[] numeros;

//Aloquei memoria.
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//simplificando um array
string[] nomes = new string[5] { "Naju", "Anne", "Célia", "Sui", "Maria" };


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de indicie: {i} : {numeros[i]}");
}

for (int l = 0; l < nomes.Length; l++) 
{
    Console.WriteLine($"Os nomes: {l} : Que estão no gole são : {nomes[l]}");
}