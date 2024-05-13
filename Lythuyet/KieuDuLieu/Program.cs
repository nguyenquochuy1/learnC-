using System;

namespace KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vi du ve khoa sizeof trong C#");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Kich co kieu int la: {0}", sizeof(int));
            Console.WriteLine("Kich co kieu float la: {0}", sizeof(float));
            Console.WriteLine("Kich co kieu double la: {0}", sizeof(double));
            Console.WriteLine("Kich co kieu char la: {0}", sizeof(char));
            Console.ReadLine();
        }
    }
}
