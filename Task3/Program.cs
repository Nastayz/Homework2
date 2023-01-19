/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер:");
string numberStr = Console.ReadLine();
int day = Convert.ToInt16(numberStr);

if ((day!=0) && (day<8)) {
    if (day < 6) {
        Console.WriteLine("нет");
    }
    else {
        Console.WriteLine("да");
    }
}
else {
    Console.WriteLine("ОШИБКА");
}