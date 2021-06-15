using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WCFBenchmark.ServiceReference1;


namespace WCFBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<WCFBenchMark>();
            Console.ReadKey();
        }

        ////手动调试使用
        //static async Task Main()
        //{
        //    var client = new MeteoriteLandingsServiceClient();
        //    var data = await client.GetLargePayloadAsync();
        //    Console.WriteLine(data);
        //    client.Close();
        //}
    }
}
