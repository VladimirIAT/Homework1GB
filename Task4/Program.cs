// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;

Write("Введите первое число ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число ");
int b = int.Parse(ReadLine()!);

Write("Введите третье число ");
int c = int.Parse(ReadLine()!);

if (a >= b & a >= c) {
    WriteLine($"max = {a}");
} else {
    if (b > c) {
        WriteLine($"max = {b}");
        } else {
        WriteLine($"max = {c}");
    }
}
    
    
