using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Ankara");
            myDictionary.Add("İstanbul");
            Console.WriteLine(myDictionary.Count);
        }
    }
}
