// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

void Even(int number1, int number2)
{
    if (number2 < number1)
    {
        return;
    }
    System.Console.Write($"{number1}-->>> ");
    Even(number1 + 2, number2);
}

int EO(int a)
{
    if (a % 2 == 1) a += 1;
    return a;
}

Even(EO(Prompt("Enter M -> ")), Prompt("Enter N -> "));