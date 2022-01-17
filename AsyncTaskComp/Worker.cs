using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_LINQ.AsyncTaskComp
{
    internal class Worker
    {

        public async Task<IEnumerable<int>> CollectDataAsync(int numberPoints)
        {
            var data = new List<int>();

            int pointsRead = 0;
            while (pointsRead < numberPoints)
            {
                //var buffer = await ReadPageAsync();
                for(int i = 0; i < 10; i++)
                  //  data.Add(buffer[i]);
                pointsRead += 10;
            }
            return data;
        }
    }
}
