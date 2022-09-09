Console.Clear();

//Метод считывает слова и создает массив слов
string[] ReadArray ()
{
    string [] inputArray = new string [5];
    for (int i = 0; i < inputArray.Length; i++)
    {
      Console.WriteLine($"Введите {i+1} слово: ");
      inputArray[i] = Console.ReadLine ()??"";
    }
return inputArray;
}

//метод печатает массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод создает массив из слов, в которых 3 или меньше символов
string[] CreateResultArray (string[] startArray)
{
    string[] resultArray = new string[startArray.Length];
    {
        for (int i = 0; i < startArray.Length; i++)
        {
            if (startArray[i].Length <= 3) 
            {
                resultArray[i] = startArray[i];
            }
        }
    }
    return resultArray;
}


string[] buffArray = ReadArray(); 
string[] resultArray = CreateResultArray(buffArray);
PrintArray(resultArray);
