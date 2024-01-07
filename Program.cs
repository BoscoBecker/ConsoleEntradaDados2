// See https://aka.ms/new-console-template for more information
using System.Globalization;// to use CultureInfo.InvariantCulture

Console.WriteLine("Informe um valor inteiro: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Você digitou: " + n1);

Console.WriteLine("Informe um valor Char: ");
char f = char.Parse(Console.ReadLine());
Console.WriteLine("você digitou: " + f);

Console.WriteLine("Informe um valor double: ");
double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Informe valores separado por espaços: ");
Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));


string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < vet.Length; i++)
{
  Console.WriteLine("você informou : " + vet[i]);
}


