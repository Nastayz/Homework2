/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите трехзначное число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int thirdNumber = (number/100)%10;  //определяем третье число

if (thirdNumber != 0) {
    Console.WriteLine($"{thirdNumber}");
}
else {
    int number321 = number % 1000; //получаем число из последних трех цифр
    if (number > number321) {
        Console.WriteLine($"{thirdNumber}");
    }
    else {
        Console.WriteLine("Третьей цифры нет");
    }
}

