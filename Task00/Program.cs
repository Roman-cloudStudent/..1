//Напишите программу, которая 
//1. на вход (принимает число)
//2. выдаёт его квадрат (число
//умноженное на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.WriteLine("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"квадрат числа {number} = {square}");

// int -2 147 483 648 до 2 147 483 648

//double d = 4/565;
//string str = "Привет";
//bool b = false;
//int num = default;

//Console.WriteLine("d");
//Console.WriteLine("str");
//Console.WriteLine("b");
//Console.WriteLine("num");

