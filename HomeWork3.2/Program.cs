﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputInt(string message)                                //название метода
{
    System.Console.Write($"{message}> ");                 //вывод приглашения ко вводу
    int value;                                            // инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value))      //проверка условия корректности ввода + ввод со строки
    {                                                      //если конвертация строки прошла правильно, то мы попадаем в ветку, 
        return value;                                      //которая находится в скобках после наименования функции. Если да
    }                                                       //то выдает первое значение (ввод со строки). Нет - второе (out )
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                  //если TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                             //нужна для компиляции.
}

int number = InputInt("Введите число N, до которого нужно вычислить кубы чисел");  //запуск функции ввода числа number

for (int i = 1; i <= number; i++)   //у цикла for Три параметра: 1- инициализация, 2 - условие продолжение, 3 - команда в конце каждого цикла
{
    int cube = i * i * i;              //заводим переменную = кубу счетчика
    System.Console.Write($"{cube}, ");  //вывод ккуба на экран в одну строку
}