// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 11);
    }
    return arr;
}

int Stiv(int[] arr)
{
    int chet = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i % 2) == 1)
        {
            chet += arr[i];
        }
    }
    return chet;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

System.Console.WriteLine($"[ {string.Join(", ", array)} ] ");
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {Stiv(array)} ");
