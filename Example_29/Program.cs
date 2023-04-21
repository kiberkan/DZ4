// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

double [] CreatingAnArray()
{
    int len = 0;
    System.Console.WriteLine("Введиде длину массива(Целое число)");
    len = Convert.ToInt32(Console.ReadLine());
    if (len > 0)
    {
        double [] arr = new double[len];

        for (int i = 0; i < len; i++)
        {
        Console.WriteLine("Введите элемент массива");
        arr[i] = double.Parse(Console.ReadLine()!);
        }
       
    return arr;
    }
    else
    {
        System.Console.WriteLine("Вы ввели отрицательное число");
        double[] erors = new double[0];
        return erors;
    }
}

void PrintArray(double[] collection)
{
    int length = collection.Length;
    System.Console.Write("Массив: {");
    for (int i = 0; i < length; i++)
    {
        Console.Write(collection[i]);
        Console.Write(i < length -1 ? ","  : "" );
    }
     System.Console.Write("}");
}


double[] arr = CreatingAnArray();
PrintArray(arr);
