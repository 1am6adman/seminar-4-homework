// Функция подсчета цифр 
int NumLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр 
void SumNum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

// Функция ввода
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int num = ReadInt("Введите число ");

int len = NumLen(num);
SumNum(num, len);