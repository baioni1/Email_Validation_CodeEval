using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation_Code_Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Dra  GON_33@face.com";
            string expLine = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (System.Text.RegularExpressions.Regex.IsMatch(line, expLine))
            {
                if (System.Text.RegularExpressions.Regex.Replace(line, expLine, string.Empty).Length == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine();




            //{
            //    if (sbLine = Regex.Match()
            //        Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}        
        }
    }
}
      



