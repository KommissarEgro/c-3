// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

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
        int square = (i * i) * i ;
        Console.WriteLine($"{i, 3}{square, 5}");
    }

}