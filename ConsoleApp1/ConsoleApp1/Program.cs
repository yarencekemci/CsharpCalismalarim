using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Yaren");

            ArrayList x = new ArrayList();

            x.Add("Yaren");
            x.Add("Zafer");
            x.Add("Cem");
            x.Add("Tolga");

            Console.WriteLine("Bu array listesinde bu kadar eleman var: "+x.Count);

            foreach (var item in x)
            {
                Console.WriteLine("eleman: "+item.ToString());
            }
        }
    }
}
