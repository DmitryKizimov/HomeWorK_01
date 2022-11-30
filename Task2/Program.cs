// Task 2 - Three digit input, that shows maximum
int[] digits = new int[3]; 

Console.Write("Введите первое число:");
digits[0] = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
digits[1] = int.Parse(Console.ReadLine());

Console.Write("Введите третье число:");
digits[2] = int.Parse(Console.ReadLine());

int maximum = digits[0];
int i = 1;

while (i < 3)
{
    if (digits[i] > maximum)
    maximum = digits[i];
    i++;
}

Console.WriteLine("Наибольшее число из трёх, введёных вами: ");
Console.WriteLine(maximum);