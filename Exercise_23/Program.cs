//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число");
try{
    int x=Convert.ToInt32(Console.ReadLine());
    int i=1;
    while(i<=x)
    {
        if(i==x)
        {
        double z = Math.Pow(i,3);
        Console.Write(z);
        }
        else
        {
        double z = Math.Pow(i,3);
        Console.Write(z+",");

        }
        i++;
    }
}
catch
{
    Console.WriteLine("Введте корректные данные");
}
