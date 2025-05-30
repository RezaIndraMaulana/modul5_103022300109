using System;

namespace GenericMethod
{
    class SimpleDataBase<T>
    {
        public List<T> storedData;
        public List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            DateTime currentTime = DateTime.Now;
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data berisi: {0}, yang disimpan pada waktu UTC: {1}", storedData[i], inputDates[i]);
            }
        }
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> simple = new SimpleDataBase<int>();
            simple.AddNewData(10);
            simple.AddNewData(30);
            simple.AddNewData(22);
            simple.PrintAllData();

            PemrosesData pemrosesData = new PemrosesData();
            pemrosesData.DapatkanNilaiTerbesar<long>(10, 30, 22);
        }
    }
}
