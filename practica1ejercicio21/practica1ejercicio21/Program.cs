//21.Realizar un programa que calcule el promedio de una lista de números.

Console.WriteLine("¿Cuántos números quieres?");
int n = int.Parse(Console.ReadLine());
double suma = 0;
for (int i = 0; i < n; i++)
{
    suma += double.Parse(Console.ReadLine());
}
Console.WriteLine("Promedio: " + (suma / n));
