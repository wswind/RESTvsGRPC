using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WCFBenchmark.ServiceReference1;

namespace WCFBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<WCFBenchMark>();
            Console.ReadKey();

            //var client = new MeteoriteLandingsServiceClient();
            //var data = await client.GetSmallPayloadAsync();
            //Console.WriteLine(data);
            //client.Close();
        }
    }
}
