Console.WriteLine("Задача№8");
Console.WriteLine("Введи число N:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < N)
{
    Console.Write("Чётное число = ");
    Console.WriteLine(count + 1);
    count +=2;
}