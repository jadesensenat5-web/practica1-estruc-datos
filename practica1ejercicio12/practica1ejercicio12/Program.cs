//12.Realizar un programa que al introducir dos números (inicio y final) muestre el rango entre ellos.

Console.WriteLine("Introduce el inicio:");
int valor_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el final:");
int valor_2 = int.Parse(Console.ReadLine());
for (int i = valor_1; i <= valor_2; i++)
{
    Console.WriteLine(i.ToString());
}