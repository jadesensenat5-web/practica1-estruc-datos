//15.Realizar un programa que determine si un número es capicúa.

Console.WriteLine("Introduce el valor:");
string valor_1 = Console.ReadLine();
string invertido = "";
for (int i = valor_1.Length - 1; i >= 0; i--)
{
    invertido += valor_1[i];
}
if (valor_1 == invertido) Console.WriteLine("Es Capicua");
else Console.WriteLine("No es Capicua");
