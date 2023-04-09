/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


Console.WriteLine("Введите длину массива:  ");
int size = int.Parse(Console.ReadLine());
int[] numb = new int[size];
RandonNumbers(numb);
PrintArray(numb);

void RandonNumbers(int[] numb)
{
    for (int i = 0; i < size; i++)
    {
        numb[i] = new Random().Next(99, 999);
    }
}

int count = 0;
for (int a = 0; a < numb.Length; a++)
{
    if (numb[a] % 2 == 0)
        count++;
}
Console.WriteLine($"из {numb.Length} чисел, {count} четных");


void PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i] + " ");
    }
}

