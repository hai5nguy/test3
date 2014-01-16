using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            //test  test5
            string Name = "blah1 |  blah2 | blah3|     ||";
            string[] separators = new string[] {"|"};

            string[] Names = Name.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray();

            
        }
    }
}
