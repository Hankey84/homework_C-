// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
{
    tempArray[i] = rand.Next(leftRange, rightRange + 1);
}

return tempArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] ReverseArray(int[] array)
{
    int[] tempArray = new int[array.Length];
    for (int i=0; i < array.Length; i++)
        tempArray[i] = array[array.Length-i-1];
    return tempArray;
}

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 99);
PrintArray(myArray);
PrintArray(ReverseArray(myArray));

//2-й способ решения задачи, самый оптимальный)
// Array.Reverse(myArray);
// PrintArray(myArray);