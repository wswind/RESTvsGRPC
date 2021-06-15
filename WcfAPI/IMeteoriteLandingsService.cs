﻿using ModelLibraryWCF.WCF;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfAPI
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IMeteoriteLandingsService
    {
        [OperationContract]
        string GetSmallPayload();

        [OperationContract]
        IEnumerable<MeteoriteLanding> GetLargePayload();

        [OperationContract]
        string PostLargePayload(IEnumerable<MeteoriteLanding> meteoriteLandings);
    }
}
