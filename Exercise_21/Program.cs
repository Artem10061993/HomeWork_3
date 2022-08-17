// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки");
try
{
    int ax=Convert.ToInt32(Console.ReadLine());
    int ay=Convert.ToInt32(Console.ReadLine());
    int az=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки");
    int bx=Convert.ToInt32(Console.ReadLine());
    int by=Convert.ToInt32(Console.ReadLine());
    int bz=Convert.ToInt32(Console.ReadLine());

    double z = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));

    Console.WriteLine("Расстояние между двух точек ="+z);
}
catch
{
    Console.WriteLine("Введте корректные данные");
}