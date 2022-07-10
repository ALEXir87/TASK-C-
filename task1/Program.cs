Console.WriteLine("Задача№2");
Console.WriteLine("Введи число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
    Console.Write("min = ");
    Console.WriteLine(numberA);
}
if (numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.WriteLine(numberB);
}