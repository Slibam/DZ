//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
int chislo = 1;
Console.WriteLine("Write number N: ");
int N = Convert.ToInt32(Console.ReadLine());
    for (int i = chislo; i <= N; i++)
        {
            if (i % 2 == 0) 
            {
             Console.WriteLine(i + " ");
            }
        }