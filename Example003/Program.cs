﻿//Задача 26: Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumber (int number)
{
    int count = 0; // Счётчик (считает колличества чисел)
    while (number > 0)
    //Используем следующий механизм: number / 10;
    // Если namber = 1234, то number / 10 (123), т.е. отсекаем от числа по одной цифре.
    // далее 123 / 10 =12; 12 / 10 = 1; 1 / 10 = 0.
    // И соответственно в результате каждого деления прибавляется переменная count++.
    {
       count++; // count = count + 1
       number /= 10; // деление на 10
    }
    return count;
}    
Console.WriteLine($"Колличество цифр в числе {GetCountNumber(num)}");