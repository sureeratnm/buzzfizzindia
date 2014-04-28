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

            Dictionary<int, string> dObj = new Dictionary<int, string>(5);
            Program p1 = new Program();
            Console.WriteLine(p1.sample<int>(2, 4));
            Console.WriteLine(p1.sample<string>("my","coding"));
            //add elements to Dictionary

            dObj.Add(1, "Tom");
            dObj.Add(2, "John");
            dObj.Add(3, "Maria");
            dObj.Add(4, "Max");
            dObj.Add(5, "Ram");

            //print data
            for (int i = 1; i <= dObj.Count; i++)
            {
                Console.WriteLine(dObj[i]);
            }
            Console.ReadKey();
        //    int aa = 0;
        //    Program pm = new Program();
        //    for (int j = 1; j <= 500; j++)
        //    {
        //        List<int> res = pm.GetIntArray(j);
        //        int lenght = res.Count();
        //        for (int k = 0; k <= lenght - 1; k++)
        //        {
        //            StringBuilder sb = new StringBuilder();
        //            if (res[k] == 3 || res[k] == 5)
        //            {
        //                if (res[k] == 3)
        //                    Console.Write("fizz");
        //                else if (res[k] == 5)
        //                    Console.Write("buzz");
        //                else
        //                    Console.Write("FizzBuzz");

        //                aa = 1;
        //            }

        //        }
        //        if (aa == 1)
        //        {
        //            aa = 0;
        //        }
        //        else
        //        {
        //            Console.Write(j);
        //            aa = 0;
        //        }
        //        Console.WriteLine();
        //    }

        //}


        //public List<int> GetIntArray(int num)
        //{

        //    List<int> listOfInts = new List<int>();
        //    while (num > 0)
        //    {
        //        listOfInts.Add(num % 10);
        //        num = num / 10;
        //    }

        //    listOfInts.Reverse();
        //    return listOfInts.ToList();
        }

        public object sample<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }

    }
}
