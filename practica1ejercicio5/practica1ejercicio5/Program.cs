// //Realizar un programa que te permita introducir un nombre y una edad y decir si es adulto o menor.

Console.WriteLine("Introduce el nombre:");
string valor_1 = Console.ReadLine();

Console.WriteLine("Introduce la edad:");
int valor_2 = int.Parse(Console.ReadLine());

if (valor_2 >= 18)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Menor");
}