
//HOMEWORK

// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Добавил массив // https://metanit.com/sharp/tutorial/2.4.php
// Перебор массивов
// Для перебора массивов мы можем использовать различные типы циклов. Например, цикл foreach:

// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers)
// {
//     Console.WriteLine(i);
// }

// ПРИМЕР:
// a=50 => нет
// a=7 => нет
// a=322 => да

// int [] numbersQ1 = {50, 7, 322};
// int D = 7;
// int S = 23;
// foreach (int i in numbersQ1) 
// {
// {
// Console.Write($"Число {i + " "}");
// }
// if (i % D ==0 && i % S ==0)
// {
//     Console.WriteLine($"одновременно кратно числу {D} и числу {S}.");
// }
// else
// {
//     Console.WriteLine($"не кратно одному из чисел или обоим числам {D} и {S}.");
// }
// }


// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// ПРИМЕР
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

// int X = 2;
// int Y = 3;
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат первой четверти.");
// }
// if (X < 0 && Y > 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат второй четверти.");
// }
// if (X < 0 && Y < 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат третьей четверти.");
// }
// if (X > 0 && Y < 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат четвертой четверти.");
// }



// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Добавил две функции к программе: 1.if (digit <= 99 && digit >= 10) 2. else if (oneDigit == secondDigit)
// вот здесь смотрел https://metanit.com/sharp/tutorial/2.5.php
// При необходимости можно добавить несколько выражений else if:
// string name = "Alex";

// if (name == "Tom")
//     Console.WriteLine("Вас зовут Tomas");
// else if (name == "Bob")
//     Console.WriteLine("Вас зовут Robert");
// else if (name == "Mike")
//     Console.WriteLine("Вас зовут Michael");
// else
//     Console.WriteLine("Неизвестное имя");


// int digit = 66;
// if (digit <= 99 && digit >= 10)
// {
// int oneDigit = (digit / 10);
// int secondDigit = (digit % 10);
//  if (oneDigit < secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. {secondDigit}>{oneDigit}.");
// }
// else if (oneDigit > secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. {oneDigit}>{secondDigit}.");
// }
// else if (oneDigit == secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. Большего нет, числа равны {oneDigit}={secondDigit}.");
// }
// }
// else 
// {
//     Console.WriteLine($"Число {digit} не подходит. Напишите число от 10 до 99.");
// }

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// ПРИМЕР:
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

// int myInt = 21325425;
//  string myString = myInt.ToString(); // моя строка это мое число в строке в символах
// char[] charArray = myString.ToCharArray(); // Массив = моей строке 
// foreach (char i in charArray) // цикл foreach проход массива 
// {
// int charparse = int.Parse(i.ToString()); // делаем из символов числа
//     Console.Write(charparse + ",");

// }


        

