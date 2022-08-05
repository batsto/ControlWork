
string[] str = {"1234", "567", "asd", "fghjl", "sport", "ref123", "9", "345", "javascript", "pyton", "tre"};



//Создаем функцию для подсчета количества строк, длина которых меньше либо равна 3.
int AmountElementsArray(string[] strings)
{
    int count = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

// Создаем функцию которая создает новый массив строк длинной равной или меньше 3.
string[] NewStringArray(string[] strings, int amount)
{
    string[] result = new string[amount];
    int index = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if(strings[i].Length <= 3)
        {
            result[index] = strings[i];
            index++;
        }
    }
    return result;
}

//Создаем функцию для печати массива в консоле.
void PrintArray(string[] strings)

{
    for (int i = 0; i < strings.Length; i++)
    {
        Console.WriteLine($"{strings[i]}");
    }
}