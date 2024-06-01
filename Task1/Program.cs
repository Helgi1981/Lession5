﻿// Задача №1

// Вычислить факториал от натурального числа N

// N! = 1*2*…*N

// 3! = 1*2*3 = 6
// 5! = 1*2*3*4*5 = 120

// 10! = 3 628 800

// 1! = 1
// 0! = 1

// (N-1)! – более простая задача
// N! = N*(N-1)*…*1

// Этапы создания рекурсии:
// 1. Рекурсивный вызов
// 2. Условие остановки рекурсии

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}"); // запуск отладочной строки
        return 1;
    }
    Console.WriteLine(n); // вывод вызова всех чисел n, согласно рекурсии
    return n * Fact(n - 1);
}

Console.Write(Fact(5));

// F11 - шаг с заходом
// F12 - шаг с обходом
// F5 - продолжить (до следующей точки)