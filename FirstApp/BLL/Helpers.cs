using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.BLL
{
    public class Helpers
    {
        public static bool DecimalTest(string target)
        {
            bool validTest = true;
            decimal number = -1;

            if (decimal.TryParse(target, out number))
            {
                var parts = target.Split('.');

                // Test for decimals
                if (parts.Length != 1)
                {
                    // There are decimals, but is there eactly 3 of them
                    if (parts[1].Length != 3)
                        validTest = false;
                }
                else
                    validTest = false;
            }

            return validTest;
        }

        public static void WriteList(List<string> lst, string fName)
        {
            string path = @"C:\\Misc\\" + fName + ".txt";
         
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (String l in lst)
                    tw.WriteLine(l);
            }
        }
    }
}
