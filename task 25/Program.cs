// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант 1

// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// void FindDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(a + " в степени " + b + " = " + result);
// }

// int numberA = WorkWithUser("Введите число: ");
// int numberB = WorkWithUser("Введите степень: ");
// FindDegree(numberA, numberB);


// Вариант 2
// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// int FindDegree(int a, int b)
// {
//     int degree = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         degree = degree * a;
//     }
//     return degree;
// }

// int a = WorkWithUser("Введите число: ");
// int b = WorkWithUser("Введите степень: ");
// Console.WriteLine(FindDegree(a, b));


