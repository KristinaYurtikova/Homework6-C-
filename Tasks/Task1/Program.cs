// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArrayElements()

{
    Console.Write ("Введите через пробел любое количество чисел:");
    string elements = Console.ReadLine()!;
    string[] elementsSplited = elements.Split(' ');
    int[] array = new int [elementsSplited.Length];

    for (int i=0; i < elementsSplited.Length;i++)
    {
        array[i] = int.Parse(elementsSplited[i]);
    }
    return array;
}


int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count+= 1;
        }
    }
    return count;
}

Console.WriteLine($"Положительные числа среди введенных чисел: {CountPositiveNumbers(InputArrayElements())}");
