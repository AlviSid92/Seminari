Console.WriteLine("введите два числа:");
int a, b;
Console.WriteLine("Первое число -");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число -");
b = Convert.ToInt32(Console.ReadLine());
bool C1 = a > b;
bool C2 = a == b;
bool C3 = a < b;

if(C1)
{
    Console.WriteLine($"Number {a} > {b}");
}
else if(C2)
{
    Console.WriteLine($"Number {a} = {b}");
}
else
{ 
    Console.WriteLine($"Number {a} < {b}");
}