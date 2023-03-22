// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа

using System;
using static System.Console;

Clear();

string[] array = {"1234", "1567", "-2", "computer science"};
int count = ArrayCheck(array);
string[] resultArray = FillResultArray (array, count);

int ArrayCheck(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        count++;
    }
    return count; 
}

string[] FillResultArray (string[] array, int count)
{
    string[] result = new string[count];
 for (int i = 0; i < array.Length; i++)
    {
 if (array[i].Length <= 3)
        {
 result[result.Length - count] = array[i];
 count--;
        }
    }
 return result;
}

void PrintArray(string[] array)
{
 Write("[");
 for (int i = 0; i < array.Length - 1; i++) 
 Write($"{array[i]}, ");
 Write($"{array[array.Length - 1]}]");
}
PrintArray(resultArray);