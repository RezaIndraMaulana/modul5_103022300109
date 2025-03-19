using System;

namespace GenericMethod
{
    class PemrosesData
    {
        
        public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic d1 = data1;
            dynamic d2 = data2;
            dynamic d3 = data3;

            if(d1 > d2 && d1 > d3)
            {
                Console.WriteLine("Data1: {0} adalah nilai terbesar", data1);
            }
            else if (d2 > d1 && d2 > d3)
            {
                Console.WriteLine("Data2: {0} adalah nilai terbesar", data2);
            }
            else
            {
                Console.WriteLine("Data3: {0} adalah nilai terbesar", data3);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            PemrosesData pemrosesData = new PemrosesData();
            pemrosesData.DapatkanNilaiTerbesar<long>(10, 30, 22);
        }
    }
}