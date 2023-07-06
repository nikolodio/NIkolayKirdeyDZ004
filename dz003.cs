int size = 8;
int[] array = new int[size];
Console.WriteLine("Enter eight array elements: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write($"Массив: [ {string.Join("; ", array)} ]");