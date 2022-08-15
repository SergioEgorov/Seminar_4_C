int A = Convert.ToInt32(Console.ReadLine()); //[1;A]

int GetSumNumbers(int number)
{
    int sum = 0; // Результат
    int start = 1; // начало нашего цикла
    while (start <= number) // [1;A]
    {
        sum += start; // sum = sum + start
        start++; // start = start + 1
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");
