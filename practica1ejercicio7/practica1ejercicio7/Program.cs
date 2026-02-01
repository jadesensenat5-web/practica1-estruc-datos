// 7.Realizar un programa que muestre los números impares del 1 al 100 utilizando WHILE.

int valor_1 = 1;

while (valor_1 <= 100)
{
    if (valor_1 % 2 != 0)
    {
        Console.WriteLine(valor_1.ToString());
    }

    valor_1 = valor_1 + 1;
}