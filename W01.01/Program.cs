
double a, b, c, delta;

Console.WriteLine("Nhap he so A: ");
a = Convert.ToDouble ( Console.ReadLine() );
Console.WriteLine("Nhap he so B: ");
b = Convert.ToDouble( Console.ReadLine() );
Console.WriteLine("Nhap he so C: ");
c = Convert.ToDouble( Console.ReadLine() );
delta = b * b - 4 * a * c;

if (delta > 0)
{
    Console.WriteLine("Co 2 nghiem");
}
else if (delta == 0)
{
    Console.WriteLine("Co 1 nghiem KEP");
}
else
{
    Console.WriteLine("o nghiem");
}