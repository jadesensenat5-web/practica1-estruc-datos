// 10.Realizar un programa que al introducir un número diga si un número es primo o no.

Console.WriteLine("Introduce el primer valor:");
int valor_1 = int.Parse(Console.ReadLine());

int valor_2 = 0;
int i = 1;
while (i <= valor_1)
{
    if (valor_1 % i == 0)
    {
        valor_2 = valor_2 + 1;
    }
    i = i + 1;
}
if (valor_2 == 2)
{
    Console.WriteLine("Es Primo");
}
else
{
    Console.WriteLine("No es Primo");
}