int[] array = GetArrayRndInt();
PrintArray(array);
Console.WriteLine();
OutputReverseArray(array);
Console.ReadLine();

void OutputReverseArray(int[] a, int i = 0)
{
    if (i > a.Length - 1)
        return;
    OutputReverseArray(a, i + 1);
    Console.Write(" " + a[i]);
}
int[] GetArrayRndInt()
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(15)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(15);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}