// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
    return arr;
}

int Stiv(int[] arr)
{
    
    int min = arr[0];
    int max = arr[1];

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min) min = arr[i];
        if(arr[i]>max) max = arr[i];
    }
    int chet = max - min;
    return chet;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

System.Console.WriteLine($"[ {string.Join(", ", array)} ] ");
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Stiv(array)} ");
