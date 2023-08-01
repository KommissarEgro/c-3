//  Напишиет программу, которая принимает на вход координаты
//  двух точек и находит растояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

// double d = 5.099864545;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);  // Округление
// Console.WriteLine(dRound);

// double sqrt = Math.Sqrt(5); // Извлчение корня

// Math.Pow(23, 5);  возведение в квадрат

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double dist = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
double distRound =Math.Round(dist, 2 , MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distRound}");


double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return distance;
}