Console.WriteLine("Задача№4");
Console.WriteLine("Введи число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число C:");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B > max) max = B;
if (C > max) max = C;
{
    Console.Write("max = ");
    Console.WriteLine(max);
}