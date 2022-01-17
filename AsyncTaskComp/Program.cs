using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_LINQ.AsyncTaskComp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var worker = new Worker();

            var data = await worker.CollectDataAsync(50);

            foreach (var item in data)
                Console.WriteLine(item);
        }
    }
}
