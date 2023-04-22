// Функция возведения в степень
void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int numberA = ReadInt("Введите число ");
int numberB = ReadInt("Введите степень ");
Degree(numberA, numberB);

