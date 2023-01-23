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
int CountTwo (int [] array) {
    int count = 0;
    foreach (var item in array){
        if (item%2 == 0) {
            count++;
        }
    }
    return count;
}
int SumForOdd (int [] array) {
    int sum = 0;
    for (int i=0; i<array.Length; i=i+2) {
        sum=sum+array[i];
    }
    return sum;
}
int ReturnMax (int [] array) {
    int max = array [0];
    for (int i=0; i<array.Length; i++) {
        if (max < array [i]) {
            max = array [i];
        }
    }
    return max;
}
int ReturnMin (int [] array) {
    int min = array [0];
    for (int i=0; i<array.Length; i++) {
        if (min > array [i]) {
            min = array [i];
        }
    }
    return min;
}
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


/*
int [] RandomArray = CreateRandomArray(10,100,999);
Console.WriteLine (String.Join(" ", RandomArray));
Console.WriteLine ($"Количество четных элементов в массиве: {CountTwo(RandomArray)}");
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
int [] RandomArray = CreateRandomArray(10,0,10);
Console.WriteLine (String.Join(" ", RandomArray));
Console.WriteLine ($"Сумма элементов на нечетных позициях: {SumForOdd(RandomArray)}");
*/

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int [] RandomArray = CreateRandomArray(10,0,999);
Console.WriteLine (String.Join(" ", RandomArray));
Console.WriteLine ($"Разница между минимальным и максимальным элементами массива: {ReturnMax(RandomArray)-ReturnMin(RandomArray)}");