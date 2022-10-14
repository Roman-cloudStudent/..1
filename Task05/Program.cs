// Задача 9 
// Напишите программу, которая выводи случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 1 выводит
// 2 показывает наибольшую цифру
// 78 -> 8
// 12 -> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 =>{number}");
int firstDigit = number / 10;   // 78 / 10 = 7.8
int secondDigit = number % 10; // 78 % 10 = 8
 if(firstDigit == secondDigit) Console.WriteLine($"цифры одинаковые");
 else if(firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа = {firstDigit}");
 else Console.WriteLine($"наибольшая цифра числа = {secondDigit}");

//  еще вариант решения задачи  int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"наибольшая цифра числа = {res}");
