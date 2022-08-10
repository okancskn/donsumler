internal class Program
{
    public static void Main(string[] args)
    {

        // Implicit Conversion (Bilinçsiz Dönüşüm)

        Console.WriteLine("******Implict Conversion*******");
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a+b+c;
        Console.WriteLine("short max value: " + short.MaxValue);
        Console.WriteLine("short min value: " + short.MinValue);
        Console.WriteLine("d: " + d);

        long h = d;
        Console.WriteLine("long max value: " + long.MaxValue);
        Console.WriteLine("long min value: " + long.MinValue);
        Console.WriteLine("h: " + h);

        float i = h;
        Console.WriteLine("i: " + i);

        string e = "okkanpremium";
        char f = 'x';
        object g = e+f+d;
        Console.WriteLine("g: " + g);


        // Explicit Conversion (Bilinçli Dönüşüm)
        
        Console.WriteLine("******Explicit Conversion*******");
        int x =4;
        byte y =(byte)x;
        Console.WriteLine("y: " + y);

        int z =100;
        byte t = (byte)z;
        Console.WriteLine("t: " + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v: " + v);

        // ****** ToString Methodu ******
        Console.WriteLine("****** ToString Methodu ******");
        int xx =6;
        string yy = xx.ToString();
        Console.WriteLine("yy: " +yy);

        string zz = 26.4f.ToString();
        Console.WriteLine("zz: "+zz);

        // System.Convert
        Console.WriteLine(" ****** System.Convert ******");
        string s1 = "10",s2 ="12";
        int sayi1,sayi2;
        int Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + Toplam);
        Console.WriteLine("for Third Commit");

        // Parse Methodu
        Console.WriteLine(" ****** Parse Methodu ******");
        ParseMethodu();

        static void ParseMethodu()
        
        {
            string metin1 = "10";
            string metin2 = "10,36";

            int sayi1;
            double double1;

            sayi1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);


            Console.WriteLine("sayi1: " + sayi1);
            Console.WriteLine("double1: " + double1);


        }


    }
}