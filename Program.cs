// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




int[] array = new int[10];
Console.WriteLine($"Длинна массива = {array.Length}");
Console.WriteLine();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
int y = 0;
for (int i = 0; i < array.Length; i++)
{
   y = array[i]%2;
    if (y == 0)
    {
        count = count + 1;
    }   
}   
foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine($" Количество четных чисел = {count}");











// void Massive(int[] array)
// {
//     int count = array.Length;
//     array = new int[10];

//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"{Massive }");
