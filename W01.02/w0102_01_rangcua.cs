
//  In Hinh Rang Cua

int H, N, i, j;String str;Console.WriteLine("Nhap Chieu cao H cua 1 Tam Giac Rang Cua: ");
H = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nhap N - so Rang Cua: ");
N = Convert.ToInt32(Console.ReadLine());

for(i=0; i < H; i++)
{
    str = "";
    for(j=0; j < N * (H - 1) + 1; j++)
    {
        if ((i+j) % (H-1) == 0  || (j % (H-1) == 0 && j > 0) )
        {
            str += "* ";
        } else
        {
            str += "  ";
        }
    }
    Console.WriteLine(str);
}