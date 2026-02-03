// 11.Realizar un programa que al introducir un número es perfecto o no.

Console.WriteLine("Introduce el primer valor:");
int valor_1 = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < valor_1; i++)
{
    if (valor_1 % i == 0) suma += i;
}
if (suma == valor_1) Console.WriteLine("Es Perfecto");
else Console.WriteLine("No es Perfecto");
