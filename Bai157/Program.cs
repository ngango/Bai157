using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai157
{
    class Program
    {
        static IDictionary<int, int> d = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 5,3, 4, 7,8, 9, 1, 7,8,9,9,10 };
            XuatMang(a);
        }
        public static void XuatMang(int[] a)
        {
            int j = 0;
            int m = 1;
            for (int i=1;i< a.Length; i++)
            {
                if(a[i-1] >= a[i])
                {
                    d.Add(new KeyValuePair<int, int>(j, m));
                    j = i;
                    m = 1;
                }
                else
                {
                    m++;
                }
                if (i == a.Length - 1) d.Add(new KeyValuePair<int, int>(j, m));
            }
            int number = d.Max(x => x.Value);
            var getArray = d.FirstOrDefault(x => x.Value == number);
            for(int i=getArray.Key;i< number+ getArray.Key; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
>>>>>>> code done 157
        }
    }
}
