// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
void Check (int size) // колличество запрашиваемых чисел M
{
    int i = 0;
    int count = 0;
    while ( i < size)
    {
        Console.Write("Input numbers ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
           count ++;
           i++;
        }
        else i++;
    }
    Console.Write(count);
}

Console.Write("Inpun M numbers ");
int M = Convert.ToInt32(Console.ReadLine());
Check(M);
*/
//____________________________________________________________________________________________________________

/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCross(double be1, double ka1, double be2, double ka2)

// y = k1 * x + b1  Находим х и у
// y = k2 * x + b2

// k1 * x + b1 = k2 * x + b2

// x = (b2-b1) / (k1 - k2)

// y = k1 * ((b2-b1) / (k1 - k2)) + b1

{
    double x = (be2 - be1) / (ka1 - ka2);
    double y = ka1 * ((be2 - be1) / (ka1 - ka2)) + be1;

    Console.WriteLine($"-> ({x}; {y})");
}

Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

FindCross(b1, k1, b2, k2);
*/