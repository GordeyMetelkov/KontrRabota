int size = 3;
string [] massiv = new String [size];
void FillArray (string [] currentArray)
{
    for (int index = 0; index < currentArray.Length; index++)
    {
        Console.WriteLine("Введите элемент массива: ");
        currentArray[index] = Console.ReadLine();
    }
}
void PrintArray (string [] currentArray)
{
    Console.Write($"[  ");
    for (int index = 0; index < currentArray.Length; index++)
    {
        Console.Write($"'{currentArray[index]}'  ");
    }
    Console.WriteLine($"]");
}
void MainTask (string [] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i].Length <= 3) count++;
    }
    string [] newArray = new String [count];
    int j = -1;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i].Length <= 3)
        {
            j++;
            newArray[j] = currentArray[i];
        }
    }
    Console.Write ("Массив из элементов, состоящий из 3 и менее символов: ");
    PrintArray(newArray);
}
FillArray (massiv);
Console.WriteLine ();
Console.Write ("Задан следующий массив: ");
PrintArray (massiv);
MainTask (massiv);