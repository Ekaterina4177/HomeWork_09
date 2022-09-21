Console.Clear();
Console.Write("Введите номер задачи 64, 66 или 68: ");
int number = int.Parse(Console.ReadLine());

if (number == 64)
{
    NaturalNumbers();
}
else if (number == 66)
{
    SumNaturalNumbers();
}
else if (number == 68)
{
    Akkerman();
}
else if (number != 64 || number != 66 || number != 68)
{
    Console.WriteLine("Ошибка. Введите правильный номер задачи.");
}

/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */


void NaturalNumbers()
{
    Console.Clear();
    Console.WriteLine("Задача 64:Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
    int firstNumber = new Random().Next(1, 5);
    Console.WriteLine("Полученное рандомно первое число: " + firstNumber);
    int secondNumber = new Random().Next(5, 9);
    Console.WriteLine("Полученное рандомно второе число: " + secondNumber);
    Console.Write($"Все натуральные от числа {firstNumber} до {secondNumber}: ");
    while (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        firstNumber = firstNumber + 1;
    }
}

/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void SumNaturalNumbers()
{
    Console.Clear();
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int sumNumber = 0;
    Console.Write($"Все натуральные от числа {firstNumber} до {secondNumber}: ");
    while (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        sumNumber = sumNumber + firstNumber;
        firstNumber = firstNumber + 1;
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных чисел {sumNumber}");
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
 */
void Akkerman()
{
    Console.Clear();
    Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии.");
    Console.WriteLine();
    Console.Write("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (firstNumber < 0 || secondNumber < 0)
    {
        Console.WriteLine("Пожалуйста, введите положительные числа.");
        return;
    }
    int result = AckermannFunction(firstNumber, secondNumber);
    Console.WriteLine("Полученный ответ по формуле Аккермана: " + result);

    int AckermannFunction(int firstNumber, int secondNumber)
    {
        if (firstNumber == 0)
        {
            return secondNumber + 1;
        }
        else if (firstNumber > 0 && secondNumber == 0)
        {
            return AckermannFunction(firstNumber - 1, 1);
        }
        else if (firstNumber > 0 && secondNumber > 0)
        {
            return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
        }
        return AckermannFunction(firstNumber, secondNumber);
    }
}