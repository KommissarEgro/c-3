// Напишите программу,которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от  до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некоректные данные");
    return;
}
SquareTable(number);

void SquareTable(int num)
{
    for (int i = 0; i <= num; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i, 3}{square, 5}");
    }

}