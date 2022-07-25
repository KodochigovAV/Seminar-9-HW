// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return int.Parse(System.Console.ReadLine());
// }

int Even(int number1, int number2)
{
    if (number1 > number2)
    {
        return 0;
    }
    int answer = number1;
    System.Console.WriteLine(answer);
    return Even(number1 + 1, number2) + answer;
}

System.Console.WriteLine(Even(1, 15));