using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Validators;
using ModelLibraryWCF.Data;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using WCFBenchmark.ServiceReference1;

namespace WCFBenchmark
{
    [RPlotExporter]
    [AsciiDocExporter]
    [CsvExporter]
    [HtmlExporter]
    public class WCFBenchMark
    {
        [Params(100, 200)]
        public int IterationCount;

        readonly MeteoriteLandingsServiceClient client = new MeteoriteLandingsServiceClient();

        [Benchmark]
        public async Task WCFGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await client.GetSmallPayloadAsync();
            }
        }

        [Benchmark]
        public async Task WCFGetLargePayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await client.GetLargePayloadAsync();
            }
        }

        static MeteoriteLanding[] wcfMeteoriteLandings;
        public static MeteoriteLanding[] WCFMeteoriteLandings
        {
            get
            {
                if (wcfMeteoriteLandings == null)
                {
                    wcfMeteoriteLandings = JsonConvert.DeserializeObject<MeteoriteLanding[]>(MeteoriteLandingData.MeteoriteLandingsJson);
                }
                return wcfMeteoriteLandings;
            }
        }


        [Benchmark]
        public async Task WCFPostLargePayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await client.PostLargePayloadAsync(WCFMeteoriteLandings);
            }
        }
    }

    public class AllowNonOptimized : ManualConfig
    {
        public AllowNonOptimized()
        {
            AddValidator(JitOptimizationsValidator.DontFailOnError);

            AddLogger(DefaultConfig.Instance.GetLoggers().ToArray());
            AddExporter(DefaultConfig.Instance.GetExporters().ToArray());
            AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray());
        }
    }
}
