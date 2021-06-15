using System.Runtime.Serialization;

namespace ModelLibraryWCF.WCF
{
    [DataContract]
    public class GeoLocation
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double[] Coordinates { get; set; }
    }
}
