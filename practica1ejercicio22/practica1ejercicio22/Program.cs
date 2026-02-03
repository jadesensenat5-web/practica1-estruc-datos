//Realizar un programa que verifique si un año introducido es bisiesto.

Console.WriteLine("Introduce el año:");
int año = int.Parse(Console.ReadLine());

if (DateTime.IsLeapYear(año)) Console.WriteLine("Es Bisiesto");
else Console.WriteLine("No es Bisiesto");