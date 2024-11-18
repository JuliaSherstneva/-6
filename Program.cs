//Дано число n. Из чисел 1, 4, 9, 16, 25, ... напечатать те, которые не превышают n. 
//Среди чисел 1, 4, 9, 16, 25, ... найти первое число, большее n.


Console.Write("Введите n= ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 1;
while ((int)Math.Pow(number, 2) < n)
{
Console.Write(n+">"+$"{Math.Pow(number, 2)}\t");
number++;
}
{
    int sqrt = (int)Math.Sqrt(n) + 1;
    Console.WriteLine("Первое число=" +sqrt * sqrt);
}