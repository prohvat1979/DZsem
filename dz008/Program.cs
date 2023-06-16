// Принять на вход число N и вывести на экран все чётные числа от 1 до N.

System.Console.WriteLine("введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 2;

while(numberB <= numberA)
{
    System.Console.Write(numberB + " ");
    numberB += 2;
}

