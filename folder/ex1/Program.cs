// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InputCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено не число");
    }
    return number;
}

double NumbDegree(int number, int degree)
{
    int answer = 1;
    for (int i = 0; i < degree; i++)
    {
        answer = answer * number;
    }
    System.Console.Write($"Ответ: {answer}");
    return answer;
}

int number = InputCheck("Введите число: ");
int degree = InputCheck("Введите степень: ");

NumbDegree(number, degree);
