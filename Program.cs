using System;
using System.Linq;
namespace HW20_09_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number = 34659;

           string s = Convert.ToString(number);
           char[] arrchar = s.ToCharArray();
           foreach (var item in arrchar.Reverse())
           {
               Console.WriteLine(item);
           }*/
            ////////////////////////////////////////////////////////////////
            //int[] number = { 4,6,8,7,9,3,-9,-6,-6,-44,-64,};
            //var PositiveSum = number.Where(n => n > 0).Sum();
            //var NegotiveSum = number.Where(n => n < 0).Sum();
            //Console.WriteLine($"--->[{PositiveSum}:{NegotiveSum}]<---");
            //Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////

            //string[] words = { "house", "car", "office", "dota 2", "desktop" };


            //var smoleWords = words.Where(w => w != " ").OrderBy(w => w.Length);
            //foreach (var item in smoleWords)
            //{

            //Console.WriteLine(item);
            //}

            //}

            ////////////////////////////////////////////

            int[] uniqueNum = { 4, 4, 4, 4, 5, 4, 4, 4 };

            var Un = uniqueNum.GroupBy(z => z).Where(z => z.ToList().Count == 1).Select(z => z.Key);
            foreach (var x in Un)
            {
                Console.Write(x);
            }
            Console.ReadKey();
        }
    }
}
