Console.Clear();
Console.Write("Является ли введённое число чётным, введите целое число x = ");
int x = Convert.ToInt32(Console.ReadLine());

if (x%2==0)
{
    Console.Write("Да, четное");
}
else
{
    Console.Write("нет, не четное");
}