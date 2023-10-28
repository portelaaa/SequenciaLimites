int numero1 = Int32.MinValue;
int numero2 = Int32.MaxValue;
int aux;
do
{
if (numero1 != Int32.MinValue || numero2 != Int32.MaxValue)
{
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"O fim ({numero2}) não pode ser menor que o início ({numero1})");
      Console.ResetColor();
      Console.WriteLine();
}

    Console.WriteLine("Início: ");
    Int32.TryParse(Console.ReadLine()!, out numero1);

    Console.WriteLine("Fim: ");
    Int32.TryParse(Console.ReadLine()!, out numero2);

} 
while (numero1 > numero2);
aux = numero1;
Console.WriteLine();

while(aux <= numero2)
{
    Console.Write($"{aux} ");
    aux ++;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Esta foi a sequência de números de {numero1} a {numero2}");
Console.ResetColor();
Console.WriteLine();
