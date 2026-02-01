// 4.Realizar un programa que te permita introducir 2 números y muestre la división. (Incluir números enteros y decimales).

Console.WriteLine("Introduce el primer valor:");
double valor_1 = double.Parse(Console.ReadLine());

Console.WriteLine("Introduce el segundo valor:");
double valor_2 = double.Parse(Console.ReadLine());

double division = valor_1 / valor_2;

Console.WriteLine(division.ToString());