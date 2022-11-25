//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("введите число");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo % 2 == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("не чётное");
}