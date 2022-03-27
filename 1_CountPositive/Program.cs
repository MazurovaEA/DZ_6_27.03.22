// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] PromtS(string message)
{
    Console.Write(message);
    string[] arr1 = Console.ReadLine().Split(new Char[] { ' ', ',' });
        int[] arr2 = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        arr2[i] = int.Parse(arr1[i]);
    }
    return arr2;
}
int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] arr = PromtS("Введите числа => ");
int count = CountPositive(arr);
Console.WriteLine($"Количество чисел больше 0, введенных Вами => {count}");