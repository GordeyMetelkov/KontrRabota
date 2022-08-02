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