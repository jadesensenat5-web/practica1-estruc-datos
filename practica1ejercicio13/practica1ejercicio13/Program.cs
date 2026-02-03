//13.Realizar un programa que al introducir dos números (inicio y final), muestre la suma de todos sus números.

Console.WriteLine("Introduce el inicio:");
int valor_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el final:");
int valor_2 = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = valor_1; i <= valor_2; i++)
{
    suma = suma + i;
}
Console.WriteLine(suma.ToString());