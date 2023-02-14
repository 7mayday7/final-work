using static System.Console;
Clear();

Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine()!;

string[] inputArray = input.Split(' ');

string[] filteredArray = FilterArray(inputArray);

Console.Write($"Отсортированный массив: [{String.Join(", ", filteredArray)}]");


static string[] FilterArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] filteredArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            filteredArray[index] = inputArray[i];
            index++;
        }
    }

    return filteredArray;
}

