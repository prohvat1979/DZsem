// Принять на ввод 3 числа и вывести максимальное из них.

int[] numbers = new int[3];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    string input = Console.ReadLine();
        
    numbers[i] = int.Parse(input);
}

int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Максимальное число: {max}");
