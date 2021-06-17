using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            List<Department> students = JsonConvert.DeserializeObject<List<Department>>(File.ReadAllText(Environment.CurrentDirectory+"\\TestData.txt"));
            Console.ReadKey();
        }
    }
}
