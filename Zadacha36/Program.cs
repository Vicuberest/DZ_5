// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int [] array = new int [5]; // Допустим, массив из 5 элементов

int sumElements = 0;

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    
    array [i] = new Random().Next(-10,10);  // Меняем интервалы
}
Console.WriteLine($"Массив: [{String.Join(",",array)}]");

for (int i = 0; i < array.Length; i++)
{
if  (i % 2 == 1) sumElements += array[i];  //Будем считать, что счет позиций, начинается от нуля
    count ++;
}


Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumElements}");