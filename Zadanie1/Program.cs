//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int chislo2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int chislo3 = Convert.ToInt32(Console.ReadLine());
int max;
if (chislo1 > chislo2)
{
    max = chislo1;
}
else
{
    max = chislo2;
}
if (chislo2 > chislo3)
{
    max = chislo2;
}
else 
{
    max = chislo3;
}
Console.WriteLine ("Самое большое число равно");
Console.WriteLine (max);
