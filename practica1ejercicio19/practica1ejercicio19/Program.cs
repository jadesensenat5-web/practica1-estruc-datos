//19.Realizar un programa que muestre los primeros N números de la serie de Fibonacci.

Console.WriteLine("¿Cuántos números?");
int n = int.Parse(Console.ReadLine());
int a = 0, b = 1, suma;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    suma = a + b;
    a = b;
    b = suma;
}