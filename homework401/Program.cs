// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumOfDigit(int number)
{
    int curDigit = 0;
    int sum = 0;
    while (number > 0) {
        curDigit = number % 10;
        number /= 10;
        sum += curDigit;
    }
    return sum;
}

bool IfSummEven(string source)
{
    if (int.TryParse(source, out int number)&& number >= 10)
    {
        if (SumOfDigit(number) % 2 == 0) return true;
        
        return false;
    }
    else 
        return false;
}
 
bool IfExit(string source)
{
    if (source == "q" || IfSummEven(source))
        return true;
    else return false;
}


Console.WriteLine("Вводите любые числа, для остановки нажмите q или введите чётную сумму цифр числа:");
while (true) 
{
    string source = Console.ReadLine();
    if (IfExit(source)) {
        Console.WriteLine("[STOP]");
        break;
    }
}