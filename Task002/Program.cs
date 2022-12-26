/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int xa, ya, za,
    xb, yb, yz;

Console.WriteLine("Введите через пробел координаты первой точки: ");
int[] pointA = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Console.WriteLine(pointA[0]);
//Console.WriteLine(pointA[1]);
//Console.WriteLine(pointA[2]);

Console.WriteLine("Введите через пробел координаты второй точки: ");
int[] pointB = Console.ReadLine().Split().Select(int.Parse).ToArray();

double CalculateDistance(int[] pointA, int[] pointB)
{
    return Math.Sqrt((pointB[0] - pointA[0])*(pointB[0] - pointA[0]) + (pointB[1] - pointA[1])*(pointB[1] - pointA[1]) + (pointB[2] - pointA[2])*(pointB[2] - pointA[2]));
}

Console.WriteLine(CalculateDistance(pointA, pointB));