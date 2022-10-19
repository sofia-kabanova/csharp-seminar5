// Задача 35. Задайте одномерный массив 
// из 123 случайных чисел.
// Напишите программу, которая
// ищет количество элементов массива,
// значения которых лежат в диапазоне от 10 до 99
// Например (для 5 элементов):
// [16,188,6,-2,900] -> 1
// [4,-8,8,-2,9] -> 0

Console.Clear();
int[] CreateArrayRndInt (int size, int min, int max) 
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
       array[i] =  rnd.Next(min, max+1); 
    }
return array;
}
int TwoDigitNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>=10 & array[i]<=99) count++;
    }
    return count;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i<array.Length - 1) Console.Write($"{array[i]}, ");
       else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
} 

int[] arr = CreateArrayRndInt(123,0,999);
PrintArray(arr);
int result = TwoDigitNumber(arr);
Console.WriteLine($"Количество совпадений: {result}");