// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}


int NumbSum(int number)
{
    int answer = 0;
    string numberStr = Convert.ToString(number);

    for (int i = 0; i < numberStr.Length; i++)
    {
        int numbElement = Convert.ToInt32(new string(numberStr[i], 1));
        answer = answer + numbElement;
    }
    System.Console.WriteLine($"Ответ: {answer}");
    return answer;
}


int number = InputCheck("Введите число: ");
NumbSum(number);