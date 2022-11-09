
//  In Hinh Kim Cuong

int H, N, i, j;
String str;



Console.WriteLine("Nhap do dai H cua Canh HCN: ");
H = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nhap N - so hinh lap lai: ");
N = Convert.ToInt32(Console.ReadLine());

int KichCo = N * 2 * (H - 1) + 1;
int Cao = 2 * H - 1;
int Du, XTam, BienDo;

for (i = 0; i < Cao; i++)
{
    str = "";
    for (j = 0; j < KichCo; j++)
    {
        Du = j % (2 * H - 2);
        XTam = j - Du + H - 1;
        BienDo = i;
        if (i > H - 1)
        {
            BienDo = H - 1 - (i - (H - 1));
        } 
        if (
            j >= XTam - BienDo &&
            j <= XTam + BienDo
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