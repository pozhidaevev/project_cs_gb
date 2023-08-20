Console.Clear();

string[] array = {"Hello", "2", "world", ":-)"};

string[] newArray = new string[array.Length];

void CreateNewArray(string[] array, string[] newArray)
{
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
    if(array[j].Length <= 3)
        {
        newArray[i] = array[j];
        i++;
        }
    }
}

void PrintNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CreateNewArray(array, newArray);
PrintNewArray(newArray);