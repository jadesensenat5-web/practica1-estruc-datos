// 2.Realizar un programa que te permita introducir 2 números y muestre la resta. (Solo números enteros).

Console.WriteLine("Introduce el primer valor:");
int valor_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo valor:");
int valor_2 = int.Parse(Console.ReadLine());

int resta = valor_1 - valor_2;

Console.WriteLine(resta.ToString());