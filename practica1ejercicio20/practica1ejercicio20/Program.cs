//20.Realizar un programa que genere la tabla de multiplicar de un número del 1 al 10.

Console.WriteLine("¿Qué tabla quieres?");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(n + " x " + i + " = " + (n * i));
}
