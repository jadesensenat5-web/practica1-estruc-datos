//23.Realizar un programa que invierta una cadena de texto.

Console.WriteLine("Introduce el texto:");
string texto = Console.ReadLine();
string invertido = "";
for (int i = texto.Length - 1; i >= 0; i--)
{
    invertido += texto[i];
}
Console.WriteLine(invertido);
