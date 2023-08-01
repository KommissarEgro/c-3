// Напишите программу, которая принимает на вход пятизнаачное число и проверяет,
// является ли оно полидромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = CheckQuantity(number);
int CheckQuantity(int num)
{
    if (num > 100000 || num < 10000)
    {
        Console.WriteLine("Неккоректное число"); ;
    }
    return num;
}

int comparison = ComparingNumber(number);
int ComparingNumber(int numb)
{
    if (numb / 10000 == numb % 10 && numb / 1000 % 10 == numb / 10 % 10)
    {
        Console.WriteLine($"Число {number} является полидромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является полидромом");
    }
    return number;
}