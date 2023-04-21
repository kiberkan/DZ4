// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int number)
{
    int len;
    for (len = 0; number > 0; len++)
    {
        number = number / 10;
    }
    return len;
}

int SumNumbers(int number, int len)
{
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}

int number = ReadInt("Введите чсило");
int numberLen = NumberLen(number);
System.Console.WriteLine(SumNumbers(number, numberLen));

