
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
