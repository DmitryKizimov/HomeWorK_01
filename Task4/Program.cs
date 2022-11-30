// N - digit input, even digits output from 1 to N
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < N)
{
    Console.WriteLine(i + 1);
    i += 2;
}
