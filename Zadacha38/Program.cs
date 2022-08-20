// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double [5];

for (int i = 0; i < array.Length; i++)
{
    
    array [i] = new Random().Next(1,10);  // Меняем интервалы
}
Console.WriteLine($"Массив: [{String.Join(",",array)}]");

double maxElement = array[0];
double minElement = array[0];
double diff = 0;

for (int i = 0; i < array.Length; i++)
{
if (maxElement < array[i])  maxElement=array[i];

if (minElement > array[i]) minElement=array[i];
    
}

  diff = maxElement-minElement;

Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива: {maxElement}-{minElement}={diff}");