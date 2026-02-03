//14.Realizar un programa que calcule el factorial de un número introducido por el usuario.

Console.WriteLine("Introduce el valor:");
int valor_1 = int.Parse(Console.ReadLine());

long factorial = 1;

for (int i = 1; i <= valor_1; i++)
{
    factorial = factorial * i;
}

Console.WriteLine(factorial.ToString());