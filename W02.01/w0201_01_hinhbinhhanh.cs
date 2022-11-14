
//  In Hinh Kim Cuong

int H, N, i, j;
String str;



Console.WriteLine("Nhap do dai H cua Canh HBH: ");
H = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nhap N - so hinh lap lai: ");
N = Convert.ToInt32(Console.ReadLine());

int KichCo = N * 2 * (H - 1) + 1;
int Cao = H;
int DuJ;

for (i = 0; i < Cao; i++)
{
    str = "";
    for (j = 0; j < KichCo; j++)
    {
        DuJ = j % (4 * H - 4);
        
        if (
            (i==0 && DuJ >= H-1  && DuJ <= 3*H-3) ||
            (i == H-1 && ((DuJ >= 0 && DuJ <= H - 1) || (DuJ >= 3*H-3 && DuJ <= 4*H - 4)) )
            || (i + DuJ == H-1)
            || (i + DuJ == 2*H - 2)
            || (DuJ - i == 2*H - 2)
            || (DuJ - i == 3 * H - 3)
            )
        {
            str += "* ";
        }
        else
        {
            str += "  ";
        }
    }
    Console.WriteLine(str);
}