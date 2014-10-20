using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести коллич. элем. массива ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];//индекс с нуля

            //while(условия работы цикла) { ... }
            //цикл с предусловием. 0..N


            //Делает, потом думает. 1 .. N
            //do{ ... } while(условия работы программы)


            //for (Переменная внутри цикла; Уловия работы; То что делается в конце цикла\ приращение;) { ... }

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            /////////////////////////////////////////////////////////////
            //=========================================================//
            /////////////////////////////////////////////////////////////
            int min = a[0]; int max = a[0]; int imin = 0; int imax = 0;// 
            for (int i = 0; i < n; i++)                                //
            {                                                          //
                if (a[i] > max)                                        //
                {                                                      //
                    max = a[i];                                        //
                    imax = i;                                          //
                }                                                      //
            }                                                          //
            for (int i = 0; i < n; i++)                                //
            {                                                          //
                if (a[i] < min)                                        //
                {                                                      //
                    min = a[i];                                        //
                    imin = i;                                          //
                }                                                      //
            }                                                          //
            for (int i = 0; i < n; i++)                                //
            {                                                          //
                Console.Write("{0} ", a[i]);                           //
            }                                                          //
            int k = a[imin];                                           //
            a[imin] = a[imax];                                         //
            a[imax] = k;                                               //
            Console.WriteLine("");                                     //
            /////////////////////////////////////////////////////////////
            //======================================================== //
            /////////////////////////////////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
                

            Console.ReadKey();

            /*
             //int i = 0;
           // while (i < n)//Ввод массива
           // {
           //     a[i] = int.Parse(Console.ReadLine());
           //     i++;
           // }
             //i = 0;
                //while (i < n)//Вывод
                // {
                //     Console.Write("{0} ", a[i]);
                //     i++;
                // }
            a[0] = int.Parse(Console.ReadLine());
            a[1] = int.Parse(Console.ReadLine());
            a[2] = int.Parse(Console.ReadLine());
            a[3] = int.Parse(Console.ReadLine());
            a[4] = int.Parse(Console.ReadLine());
            a[5] = int.Parse(Console.ReadLine());
            a[6] = int.Parse(Console.ReadLine());
            a[7] = int.Parse(Console.ReadLine());
            a[8] = int.Parse(Console.ReadLine());
            a[9] = int.Parse(Console.ReadLine());
            a[10] = int.Parse(Console.ReadLine());
            a[11] = int.Parse(Console.ReadLine());
            a[12] = int.Parse(Console.ReadLine());
            a[13] = int.Parse(Console.ReadLine());
            a[14] = int.Parse(Console.ReadLine());

            Console.Write("{0} ", a[0]);
            Console.Write("{0} ", a[1]);
            Console.Write("{0} ", a[2]);
            Console.Write("{0} ", a[3]);
            Console.Write("{0} ", a[4]);
            Console.Write("{0} ", a[5]);
            Console.Write("{0} ", a[6]);
            Console.Write("{0} ", a[7]);
            Console.Write("{0} ", a[8]);
            Console.Write("{0} ", a[9]);
            Console.Write("{0} ", a[10]);
            Console.Write("{0} ", a[11]);
            Console.Write("{0} ", a[12]);
            Console.Write("{0} ", a[13]);
            Console.Write("{0} ", a[14]);

             */

        }
    }
}
