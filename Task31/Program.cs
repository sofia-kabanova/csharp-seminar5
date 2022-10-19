// Задайте массив из 12 элементов,
// заполненный случайными числами
// из промежутка -9, 9 
// Найдите сумму отризцательных 
// и положительных элементов массива
// например:
// Например, в массиве  [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// Сумма положит = 29, отрицат = -20.
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

int[] GetSumPosNegElem(int[] array)
{
    int sumNeg=default;
    int sumPos=default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<0) sumNeg += array[i];
        else sumPos += array[i];
    }
    
    return new int[]{sumNeg, sumPos};
}


int[] arr = CreateArrayRndInt(12,-9,9);
PrintArray(arr);
Console.WriteLine(); // первод курсора на новую строку
int[] result = GetSumPosNegElem(arr);
Console.WriteLine($"Суммв отрицательных чисел = {result[0]}");
// так как result - это массив, необходимо указать индекс элемента для вывода
// sumNeg - нулевой индекс массива, sumPos - первый индекс массива
Console.WriteLine($"Суммв положительных чисел = {result[1]}");
