/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt16(numberStr);
if ((number>99) && (number<1000)) {
    Console.WriteLine($"{(number/10)%10}");
}
else {
    Console.WriteLine("ошибка");
}
