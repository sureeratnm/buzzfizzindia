using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buzzfizzindia
{
    class Program
    {

        static void Main(string[] args)
        {


            int aa = 0;
            Program pm = new Program();
            for (int j = 1; j <= 500; j++)
            {
                List<int> res = pm.GetIntArray(j);
                int lenght = res.Count();
                for (int k = 0; k <= lenght - 1; k++)
                {
                    StringBuilder sb = new StringBuilder();
                    if (res[k] == 3 || res[k] == 5)
                    {
                        if (res[k] == 3)
                            Console.Write("fizz");
                        else if (res[k] == 5)
                            Console.Write("buzz");
                        else
                            Console.Write("FizzBuzz");

                        aa = 1;
                    }

                }
                if (aa == 1)
                {
                    aa = 0;
                }
                else
                {
                    Console.Write(j);
                    aa = 0;
                }
                Console.WriteLine();
            }

        }


        public List<int> GetIntArray(int num)
        {

            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            listOfInts.Reverse();
            return listOfInts.ToList();
        }

       

    }
}
