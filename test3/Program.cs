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

            string Name = "blah1 |  blah2 | blah3|     ||";

            string[] Names = Name.Split('|').Select(n => n.Trim()).ToArray();

            
        }
    }
}
