// 9.Realizar un programa que mediante un número introducido por teclado, muestre si el número es positivo (+), negativo(-) o neutro (0).

Console.WriteLine("Introduce el primer valor:");
int valor_1 = int.Parse(Console.ReadLine());

if (valor_1 > 0)
{
    Console.WriteLine("Positivo");
}
else if (valor_1 < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Neutro");
}