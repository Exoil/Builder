using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Builder");
            Director client = new Director(new FirstProductBuilder());

            var result = client.Contstruct();

            result.CallProduct();

            client = new Director(new SecondProductBuilder());

            result = client.Contstruct();

            result.CallProduct();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
