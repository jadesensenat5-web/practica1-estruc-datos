//17.Realizar un programa que calcule la suma de los dígitos de un número.

Console.WriteLine("Introduce el valor:");
string valor_1 = Console.ReadLine();
int suma = 0;
for (int i = 0; i < valor_1.Length; i++)
{
    suma += int.Parse(valor_1[i].ToString());
}
Console.WriteLine(suma.ToString());