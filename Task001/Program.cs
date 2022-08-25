Console.Clear();
Console.Write("введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("введите число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
}
else
{
    Console.WriteLine("max = " + number2);

}
if (number1 < number2)
{
    Console.WriteLine("min = " + number1);
}
else
{
    Console.WriteLine("min = " + number2);
}