string[] array = { "hello", "2", "world", ":-)" };
int a = 3;
string[] array2 = LengthElements(array);
foreach (string i in array2)
{
    Console.Write(i + " ");
}

string[] LengthElements(string[] arr)
{
    int j = 0;
    string[] array2 = new string[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= a)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}