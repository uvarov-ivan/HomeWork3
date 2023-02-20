// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
    return 0;                                             //Это return нужен только для компиляции, программа до него никогда не дойдёт.
}

int LenghtNumber(int num)
{
    int len = 0;
    while (num > 0)
    {
        num /= 10;
        len++;
    }

    return (len);
}

void ForOddLenght(int len, int num)
{
    len /= 2;
    int numOrig = num;
    int compared = 0;
    for (double i = 1; i <= len; i++)   //у цикла for Три параметра: 1- инициализация, 2 - условие продолжение, 3 - команда в конце каждого цикла
    {
        compared += ((num % 10) * Convert.ToInt32(Math.Pow(10, (len - i)))); // Переворачиваем вторую половину числа
        num /= 10;                                                         // Убираем крайний знак числа
    }
    num /= 10; 
    
    if (num == compared)
    {
        System.Console.WriteLine($"Число {numOrig}, является палиднромом.");
    }
    else
    {
        System.Console.WriteLine($"Число {numOrig}, не является палиндромом.");
    }
}

void ForEvenLenght(int len, int num)
{
    len /= 2;
    int numOrig = num;
    int compared = 0;
    for (double i = 1; i <= len; i++)   //у цикла for Три параметра: 1- инициализация, 2 - условие продолжение, 3 - команда в конце каждого цикла
    {
        compared += (num % 10) * Convert.ToInt32(Math.Pow(10, (len - i))); // Переворачиваем вторую половину числа
        num /= 10;                                                      // Убираем крайний знак числа
    }
    
    if (num == compared)
    {
        System.Console.WriteLine($"Число {numOrig}, является палиндромом.");
    }
    else
    {
        System.Console.WriteLine($"Число {numOrig}, не является палиндромом.");
    }
}

int number = InputInt("Введите число ");  //запуск функции ввода числа number

int lenght = LenghtNumber(number);

    // Или так, переворачиваем всё число и сраниваем с оригиналом:
    // int reverse = 0;
    // while (num > 0)
    // {
    //     reverse = reverse*10 + num%10;     //Переворачиваем вторую половину числа
    //     num /= 10;
    // }

if (lenght % 2 == 0)
{
    ForEvenLenght(lenght, number);
}
else
{
    ForOddLenght(lenght, number);
}
