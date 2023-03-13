/* ## Написать программу, которая из имеющегося массива строк 
формирует массив строк, длина которых меньше или равна трём символам */

string[] GetArray()
{
    string[] stringArray = new string[4] { "hello", "world", ":-)", "ok" };
    return stringArray;
}

string[] FindString(string[] array)
{
    string[] result = new string[0];

    foreach (string elem in array)
    {
        if (elem.Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = elem;
        }
    }
    return result;
}

Console.Clear();
string[] array = GetArray();
Console.WriteLine("[" + string.Join(", ", array) + "] => [" + string.Join(", ", FindString(array)) + "]");