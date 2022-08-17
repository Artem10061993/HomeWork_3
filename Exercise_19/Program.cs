// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное целое число");
try
{
int number = Convert.ToInt32(Console.ReadLine());
int i = 4;
int[] Array = new int[5];

    while(i>=0)
    {
        Array [i] = number%10;
        number = number/10;
        //Console.WriteLine(Array [i]);
        i=i-1; 
    }
        if(number==0)
        {
            if(Array[4]==Array[0]&&Array[3]==Array[1])
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
            }
        else
            {
            Console.WriteLine("Введенные данные не удовлетворяют условиям, введите данные еще раз");
            }
}
catch
{
    Console.WriteLine("Введенные данные не удовлетворяют условиям, введите данные еще раз");
}