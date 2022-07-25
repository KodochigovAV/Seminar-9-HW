// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Akk(int number1, int number2)
{
    if (number1 > number2)
    {
        return 0;
    }
    int answer = number1;
    System.Console.WriteLine(answer);
    return Even(number1 + 1, number2) + answer;
}

System.Console.WriteLine(Akk(3, 2));
