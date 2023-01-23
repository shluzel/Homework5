Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int CountTwo (int [] array) {
    int count = 0;
    foreach (var item in array){
        if (item%2 == 0) {
            count++;
        }
    }
    return count;
}

int [] RandomArray = CreateRandomArray(10,100,999);
Console.WriteLine (String.Join(" ", RandomArray));
Console.WriteLine ($"Количество четных элементов в массиве: {CountTwo(RandomArray)}");

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.