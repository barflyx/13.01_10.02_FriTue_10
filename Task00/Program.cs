// 0. Демонстрация решения 
// Напишите программу, которая 
// 1. на вход принимает число
// 2. и выдает его квадрат
// 3. Вывод результата
// (число умноженное само на себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // 35464747
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");