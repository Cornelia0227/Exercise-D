using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_D
{
    class Class_D2 //最大公约数和最小公倍数
    {
        public void D2()
        {
            Console.WriteLine("Please input two integer numbers(A & B): ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int H, L;
            L = A * B;
            while(A!=B && A!=0 && B!=0) //注意排除0，不然会死循环！！！
            {
                if(A>B)
                {
                    A = A-B;
                }
                else
                {
                    B = B-A;
                }
            }
            if(A!=0 && B!=0)  //注意排除0，不然会报错！！！
            {
                H = A;
                L = L / H;
                Console.WriteLine("The LCM is {0}, the HCF is {1}", L, H);
            }
            else
            {
                Console.WriteLine("The two integers include 0, there is no LCM or HCF !");
            }

        }
    }
}
