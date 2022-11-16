
int ngay, thang, nam;
int ngaykt=0, thangkt=0, namkt=0;
bool error = false;
string msg = "";

// Gia tri dung
// 1. ngay trong thang
// 2. ngay cuoi thang
// 3. ngay cuoi nam
// 4. thang 28, 29, 30, 31
// 5. Nhuan: ... 400 |  ... 4 0 ... 100
//  ...
Console.WriteLine("Tim ngay ke tiep ...");


do
{
    Console.Write("Ngay (1..31): ");
    ngay = int.Parse(Console.ReadLine());
} while (ngay < 1 ||  ngay > 31);

do
{
    Console.Write("Thang (1..12): ");
    thang = int.Parse(Console.ReadLine());
} while (thang < 1 || thang > 12);

do
{
    Console.Write("Nam (#0): ");
    nam = int.Parse(Console.ReadLine());
} while (nam == 0);

// ----------------------------

int [] soNgayThang = new int[] { 0, 31,28,31,30,31,30,
    31, 31, 30, 31, 30, 31 };

if (ngay < soNgayThang[thang])
{
    ngaykt = ngay + 1;
    thangkt = thang;
    namkt = nam;
} else if (ngay > soNgayThang[thang])
{
    error = true;
    msg = "Ngay nhap vao lon hon ngay cua thang";
} else if (thang < 12)
{
    ngaykt = 1;
    thangkt = thang+1;
    namkt = nam;
} else
{
    ngaykt = 1;
    thangkt = 1;
    namkt = nam+1;
}

// -------------------------------
if (error)
{
    Console.Write(msg);
}
else
{
    Console.WriteLine($" Ngay nhap vao {ngay} / {thang} / {nam} ");
    Console.WriteLine($" --> ke tiep la {ngaykt} / {thangkt} / {namkt} ! ");
}
