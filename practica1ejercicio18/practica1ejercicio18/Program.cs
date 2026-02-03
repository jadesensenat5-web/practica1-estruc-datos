//18.Realizar un programa que encuentre el mayor entre tres números introducidos por el usuario.

Console.WriteLine("Introduce el primer número:");
int valor_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo número:");
int valor_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el tercer número:");
int valor_3 = int.Parse(Console.ReadLine());
if (valor_1 >= valor_2 && valor_1 >= valor_3)
{
    Console.WriteLine("El mayor es: " + valor_1);
}
else if (valor_2 >= valor_1 && valor_2 >= valor_3)
{
    Console.WriteLine("El mayor es: " + valor_2);
}
else
{
    Console.WriteLine("El mayor es: " + valor_3);
}