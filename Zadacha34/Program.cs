// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = new int [10]; //Допустим, массив из 10элементов
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100,1000);
}   
Console.WriteLine($"Массив: [{String.Join("   ",array)}]");
for (int i = 0; i < array.Length; i++)
{

 if  (array[i] % 2 == 0)
    count ++;
   
}

Console.WriteLine($"Количество четных чисел в массиве = {count}");
