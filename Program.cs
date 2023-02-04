// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color; 
    Console.Write(data);
    Console.ResetColor();
}
int getUserData(string message)
{
   printInColor(message + "\n",ConsoleColor.DarkGreen);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getSumOfRange(int start, int finish)
{
    int sum = 0;
    if(start == finish && sum ==0)
    {
        return sum + start;
    }
    return sum + start + getSumOfRange(start +1, finish);
}
int userNumberStart = getUserData("Введите значение начала ряда");
int userNumberFinish = getUserData("Введите значение окончания ряда");
int start = Math.Min(userNumberStart, userNumberFinish);
int finish = Math.Max(userNumberStart, userNumberFinish);
int SumOfRange = getSumOfRange(start, finish);
Console.WriteLine(SumOfRange);