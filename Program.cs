using System;
using System.Collections.Generic;

namespace ConsoleApp15_NearlySimilarRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = null, y = null;
            //bool? a = x?.Equals(y); // null  //Note: ?. if not used it throws null reference exception
            //bool b = x == y; // true

            //string v = "AA";
            //string z = v;
            //bool c = v.Equals(z); // true
            //bool d = x == y; // true

            //int num = 10;
            //string p = null;
            //int reslt = num - p?.Length ?? 0; //o/p : 0 (10 - null)

            //double a = 5.0 / 2.0;
            //Console.WriteLine(a);      // 2.5

            //double b = 5 / 2;
            //Console.WriteLine(b);      // 2

            //double c = 1f / 2f;
            //Console.WriteLine(c);      // 0.5

            List<int> lst = new List<int>();
            lst.Add(5);

            List<int> lst1 = new List<int>();
            lst1.Add(10);
            lst1.Add(50);

            List<int> lst2 = new List<int>();
            lst2.Add(2);
            lst2.Add(10);

            List<int> lst3 = new List<int>();
            lst3.Add(8);
            lst3.Add(20);

            List<int> lst4 = new List<int>();
            lst4.Add(1);
            lst4.Add(15);
            lst4.Add(30);

            List<int> lst5 = new List<int>();
            lst5.Add(1);
            lst5.Add(5);

            List<List<int>> mainLst = new List<List<int>> { lst, lst1, lst2, lst3, lst4, lst5 }; // o/p :  3

            int nearlySimilarRectangle = 0;


            int temp1 = 0;
            foreach (var aa in mainLst)
            {
                temp1++;
                if (aa.Count > 1)
                {
                    for (var i = temp1; i < mainLst.Count; i++)
                    {
                        if (mainLst[i].Count > 1)
                        {
                            double cc = Convert.ToDouble(aa[0]) / Convert.ToDouble(mainLst[i][0]);
                            double dd = Convert.ToDouble(aa[1]) / Convert.ToDouble(mainLst[i][1]);

                            if (cc == dd)
                                nearlySimilarRectangle++;
                        }
                    }
                }
            }


            Console.WriteLine("nearly Similar Rectangle count: " + nearlySimilarRectangle);
        }
    }
}
