// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
using static System.Console;

Write("Введите первое число ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число ");
int b = int.Parse(ReadLine()!);

if (a >= b) {
    WriteLine($"max = {a}");
} else {
    WriteLine($"max = {b}");
}