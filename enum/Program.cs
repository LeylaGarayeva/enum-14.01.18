using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    
    enum big_city
    {
        Baki = 10000,
        Sumqayit = 9000,
        Gence = 8000,
        Mingecevir = 7000


    }
    class Program
    {

        static void Main(string[] args)
        {
            int sira = (int)big_city.Baki;
            Console.WriteLine();
            Console.WriteLine(sira);
            vaxt t = new vaxt(2018,1,6,12,56);
            Console.WriteLine(t.year);
            Console.WriteLine(t.words(2018, 1, 6, 12, 56));
            Console.WriteLine(reqem.cevir(22));

          
        }

    }

    struct vaxt {
       public int year;
       public  int month;
        public int hour;
        public int minut;
       public int second;

    
        public  vaxt(int y,int m,int h,int mn,int s)
        {
            year = y;
            month = m;
            hour = h;
            minut = mn;
            second = s;
           
        }

        public string words(int y, int m, int h, int mn, int s)

        {

            return "il " +y + " ay: " + (aylar)m;
        }

    }


    enum aylar {
        Yanvar=1,
        Fevral,
        Mart,
        Aprel,
        May,
        Iyun,
        Iyul,
        Avqust,
        Sentyabr,
        Oktyabr,
        Noyabr,
        Dekabr

    }

    enum herf {
        bir=1,
        iki,
        uc,
        on=10,
        iyirmi=20,
        otuz=30
    }

    public static class reqem {


        public static string cevir(this int a) {
            var r = a;
            var teklik = 0;
            var onluq = 0;
            onluq = r / 10;
            teklik = a - onluq*10;
            return ((herf)(onluq*10)).ToString() +" " +((herf)(teklik)).ToString();
        }
        

    }


}
