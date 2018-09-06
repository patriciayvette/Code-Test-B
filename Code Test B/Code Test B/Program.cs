using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            DateTime tgl = DateTime.Now;
            string karakter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            string s = "";
            for (int i = 0; i < 7; i++) {
                int m = rand.Next(karakter.Length);
                s = s + karakter[m];
            }
            s = s + tgl.ToString("dd");
            for (int i = 0; i < 5; i++)
            {
                int m = rand.Next(karakter.Length);
                s = s + karakter[m];
            }
            s = s + tgl.ToString("MM");
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
