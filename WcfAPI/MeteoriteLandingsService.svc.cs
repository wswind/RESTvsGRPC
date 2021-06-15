using ModelLibraryWCF.Data;
using ModelLibraryWCF.WCF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAPI
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class MeteoriteLandingsService : IMeteoriteLandingsService
    {
        static List<MeteoriteLanding> wcfMeteoriteLandings;
        public static List<MeteoriteLanding> WcfMeteoriteLandings
        {
            get
            {
                if (wcfMeteoriteLandings == null)
                {
                    wcfMeteoriteLandings = JsonConvert.DeserializeObject<List<MeteoriteLanding>>(MeteoriteLandingData.MeteoriteLandingsJson);
                }
                return wcfMeteoriteLandings;
            }
        }

        public IEnumerable<MeteoriteLanding> GetLargePayload()
        {
            return WcfMeteoriteLandings;
        }

        public string GetSmallPayload()
        {
            return "API Version 1.0";
        }

        public string PostLargePayload(IEnumerable<MeteoriteLanding> meteoriteLandings)
        {
            return "SUCCESS";
        }
    }
}
