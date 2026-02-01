// 8.Realizar un programa que, mediante un número introducido por teclado, muestre si es par o impar utilizando IF y ELSE.

Console.WriteLine("Introduce el primer valor:");
int valor_1 = int.Parse(Console.ReadLine());

if (valor_1 % 2 == 0)
{
    Console.WriteLine("Es Par");
}
else
{
    Console.WriteLine("Es Impar");
}
