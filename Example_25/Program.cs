// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int numberA, int numberB)
{
    int rezult = 1;
    for (int i = 0; i < numberB; i++)
    {
        rezult = rezult * numberA;
    }
    return rezult;
}

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите число");
int numberB = ReadInt("Введите степень");
int rezult = Exponentiation(numberA, numberB);
System.Console.WriteLine(numberA+ "^" +numberB+ " = " +rezult);

