// Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите целое число ");

void Palindrome (int x1, int x2, int x3, int x4, int x5)
{if(x1 == x5 & x2 == x4) Console.WriteLine("Это палиндром");
else Console.WriteLine("Число не является палиндромом");
}

try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int x1 = x/10000;
    int x2 = x/1000-x1*10;
    int x3 = x/100-(x/1000)*10;
    int x4 = x/10-(x/100)*10;
    int x5 = x%10;

    Palindrome (x1, x2, x3, x4, x5);
}

catch
{
    Console.WriteLine("Не выполнено условие по вводу корректных данных, попробуйте ввести корректные данные");
}
