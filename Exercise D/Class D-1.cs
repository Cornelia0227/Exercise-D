using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_D
{
    class Class_D1
    {
        public void D1() //lucky num
        {
            int num=0;
            while (num!=88)
            {
                Console.WriteLine("Please input an integer: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Lucky you... ");
        }
    }
}
