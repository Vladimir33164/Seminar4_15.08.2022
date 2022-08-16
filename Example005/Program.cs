//Задача 30: Напишите программу, которая 
//выводит массив из 8 элементов, заполненный 
//нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

/*
int[] GetBinaryArray (int size); //[] - массив; size - размер
{
    int[] result = new int[size]; //изначально, это будет выглядеть так, size = 2; [0;0]
    for (int i = 0; i < result.Length; i++) // З А П О М Н И Т Ь!!! size = rezult.Lenght. Это одинаковые выражения.
    {
        result[i] = new Random().Next(2); //result - переменная(имя) нашего массива, i - массив.
                                            Обращаеься к конструкции new Random(чтобы получить рандомное число).
                                            И вызываем метод Next(где указываем 2 параметра: 0;2).
                                            З А П О М Н И Т Ь!!! Если мы укажем число 2. То автоматически метод берёт числа от 0 до 2.         
    }
    return result;
}
int[] testArray = GetBinaryArray(8);
Вызовем метод GetBinaryArray на 8 чисел (по условию задачи), через некоторый массив testArray.
Console.WriteLine($"Массив: [ {String.Join(", ",testArray)} ]");
*/
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
int[] testArray = GetBinaryArray(8);
Console.WriteLine($"Массив: [ {String.Join(", ",testArray)} ]");
