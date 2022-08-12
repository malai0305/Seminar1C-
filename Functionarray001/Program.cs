// Дан массив из 10 целых чисел в диапазоне от [-99,60] заменить в этом массиве отрицательные числа на 0.
void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(int[] array, int minmum, int maximum)
{
    var random = new Random();
    for(int i=0;i<array.Length;i++)
        array[i] = random.Next(minmum, maximum + 1);
}
void ChangeArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
        if (array[i] < 0)
            array[i] = 0;
}
Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
var array = new int[size];
FillArray(array, -99, 60);
PrintArray(array);
ChangeArray(array);
PrintArray(array);
