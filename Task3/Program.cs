// Even / odd digit
Console.WriteLine("Введите число:");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 2 == 0)
    Console.WriteLine("Вы ввели чётное число");
else
    Console.WriteLine("Вы ввели нечётное число");
    