// Напишиет программу, которая приимает на вход координаты точки (X,Y),
// причем Х != 0 и Y != 0 и выдает номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.WriteLine("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xCoordinate, yCoordinate);
string result = quater > 0 
                ? $"Указзаные координаты соотвесвуют четверти {quater}" 
                : "Введены некоректные коодинаты";

Console.WriteLine(result);

int Quater(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}