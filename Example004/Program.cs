//Задача 28: Напишите программу, которая 
//принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.

//4 -> 24 
//5 -> 120
// Факториал, это произведение чисел от 1 до N. N! = 1 * 2 * 3...N.

int num = Convert.ToInt32(Console.ReadLine());
int GetMultiply (int number)
{
    int result = 1; // 2 * 0 = 2; при умножении указываем 1: любое число на 1 = число.
    for (int i = 1; i <= number; i++)
    {
        result *= i;
        // То есть, num = 3; i = 1; result = 1
        // result = result * i (1 * 1); i++(i = 2);
        // result = result * i (2 * 1) => result = 2; i++ = 2 + 1 = 3;
        // result = result * i (2 * 3) => result = 6; i++ = 3 + 1 = 4;
    }
    return result;
}
Console.WriteLine($"Факториал от {num} = {GetMultiply(num)} ");
