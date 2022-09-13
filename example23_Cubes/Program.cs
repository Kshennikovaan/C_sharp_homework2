// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел от 1 до N.

string squareTable(int num)
{
    string result = $"{num} -> 1";
    for(int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i, 3)}";
    }
    return result;
}

try
{
    System.Console.Write("Введите целое число N = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(squareTable(num));
}
catch
{
    System.Console.WriteLine("Нужно было ввести целочисленное значение");
}


