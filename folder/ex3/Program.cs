// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int RandomMass()
{
    int zero = 0;
    Random rand = new Random();
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = rand.Next(1, 101);
    }
    System.Console.WriteLine("Массив: " + string.Join(", ", array));
    return zero;
}

RandomMass();