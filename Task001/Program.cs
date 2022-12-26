/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
bool IsPolindrome(string number)
{
    return number[0] == number[4] && number[1] == number[3];
}

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine() ??"";

if (IsPolindrome(number))
{
    Console.WriteLine("Это полиндром");
}
else Console.WriteLine("Это не полиндром");

