/*
Задача 64: Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.
N = 4 -> 24
*/

// int Factorial(int numberFactorial)
// {
//     if (numberFactorial == 1) return 1;
//     else return numberFactorial * Factorial(numberFactorial - 1);
// }

// Console.Write("Input factorial of a number: ");
// int numberInput = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Factorial of a number: " + Factorial(numberInput));

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// int NumberSumma(int m, int n)
// {
//     if (m < n) return NumberSumma(m, n - 1) + n;
//     else return m;
// }

// Console.Write("Input number M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of natural elements between M and N: " + NumberSumma(numberM, numberN));