// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



void MassivInReverseOrder (int[] numbers, int index)
{
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(numbers[index]);
        MassivInReverseOrder(numbers, index - 1);
    }
}

int[] numbers = { 1, 2, 3, 4, 5 };
MassivInReverseOrder(numbers, numbers.Length - 1);