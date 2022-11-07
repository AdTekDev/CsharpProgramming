using System;

class Program {
  public static void Main (string[] args) {
    int X = 60;
    int Y, i, MAX;
    Boolean ChuaDung = true;
    
    MAX = 6;
    i = 0;
    
    while (i < MAX  && ChuaDung)
    {
        i++;
        Console.WriteLine("Ban nhap so can DOAN lan thu {0} : ", i);
        Y = Convert.ToInt32(Console.ReadLine());
    
        if (Y > X) {
            Console.WriteLine("so LON roi !");
        } else if ( Y < X ) {
            Console.WriteLine("so NHO roi !");
        } else {
            Console.WriteLine("DUNG {0} roi !", X);
            ChuaDung = false;
        }
    }

  }
}

