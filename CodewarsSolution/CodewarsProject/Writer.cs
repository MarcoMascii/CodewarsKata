using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public class Writer
    {
        public static void WriteLine(string line)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(@"C:\Users\Marco\Desktop\test.csv"))
                {
                    writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = File.AppendText(@"C:\"))
                {
                    writer.WriteLine(string.Concat("Can't find path specified to write logs", ex));
                }
            }
        }
    }
}
