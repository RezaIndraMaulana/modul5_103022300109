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

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> simple = new SimpleDataBase<int>();
            simple.AddNewData(10);
            simple.AddNewData(30);
            simple.AddNewData(22);
            simple.PrintAllData();
        }
    }
}