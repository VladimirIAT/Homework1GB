// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;

Write("Введите число ");
int a = int.Parse(ReadLine()!);
int b = a%2;

if (b == 0) {
    WriteLine("Да, число четное");
} else {
    WriteLine("Нет, число нечетное");
}
