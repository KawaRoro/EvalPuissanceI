using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> uniqueNoList = new List<int>(3) { RandomNumber(-10000, 10000), RandomNumber(-10000, 10000), RandomNumber(-10000, 10000), RandomNumber(-10000, 10000) };
            foreach (int num in uniqueNoList)
            {
                Console.Write($"{num}, ");
            }

            List<int> uniqueNoListResult = CheckNoList(10000, 10, uniqueNoList.OrderByDescending(number => number).ToList());

            Console.WriteLine("/n");

            Console.WriteLine("Result : ");

            foreach (int no in uniqueNoListResult)
            {
                Console.WriteLine(no);
            }

            Console.ReadLine();
        }
        public static List<int> CheckNoList(int maxRange, int totalRandomNoCount, List<int> _uniqueNoList)
        {
            List<int> noList = new List<int>();
            int countFound = 0;
            //int countNotFound = 0;

            List<int> listRange = new List<int>();
            
            for (int i = 1; i < maxRange; i++)
            {
                listRange.Add(i);
            }

            int e = 0;

            while (listRange.Count > 0)
            {
                int item = listRange[e];// listRange[];  
                if (!noList.Contains(item) && listRange.Count > 0)
                {

                    //Console.WriteLine(" noList.Contains(item)");
                    //Console.WriteLine(item);
                    for(int j=0; j < _uniqueNoList.Count; j++)
                    {
                        if (item != (-_uniqueNoList[j]))
                        {
                            noList.Add(item);
                            listRange.Remove(item);
                            countFound++;
                            //Console.WriteLine(item);
                        }
                    }

                }
                e++;
            }

            return noList;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
