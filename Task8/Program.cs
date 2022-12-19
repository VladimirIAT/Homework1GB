// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;

Write("Введите число ");
int a = int.Parse(ReadLine()!);
int b = 0;

if (a < 2) {
    WriteLine("Нет четных чисел");
    } else {
        while (b < a) {
            b = b + 2;
            if (b <= a) {
                WriteLine($"{b}, ");
            }
        }
    }

