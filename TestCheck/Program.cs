using System;
using System.Collections.Generic;

namespace TestCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new Dictionary<bool, string>()
                { { false, "No" }, { true, "Yes" } };

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string line = " " + string.Join(" ", array);
            bool key = Convert.ToBoolean(1 + line.IndexOf(" 0"));

            Console.WriteLine(messages[key]);
            Console.Read();
        }
    }
}
