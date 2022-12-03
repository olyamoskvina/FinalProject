string[] CreateArray()
{
    string[] array = new string[5];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] myArray = CreateArray();

string[] newArray = new string[myArray.Length];

void SecondArray(string[] myArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
    if(myArray[i].Length <= 3)
        {
        newArray[count] = myArray[i];
        count++;
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {                                                     
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


SecondArray(myArray, newArray);
ShowArray(newArray);
