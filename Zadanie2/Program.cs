//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("введите первое число");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int chislo2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (chislo1 > chislo2)
{
    max = chislo1;
    min = chislo2;
}
else 
{
    max = chislo2;
    min = chislo1;
}
Console.WriteLine ("большое второго числа");
Console.WriteLine (max);
Console.WriteLine ("меньше второго числа");
Console.WriteLine (min);