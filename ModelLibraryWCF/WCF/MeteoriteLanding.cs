using System;
using System.Runtime.Serialization;

namespace ModelLibraryWCF.WCF
{
    [DataContract]
    public class MeteoriteLanding
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Fall { get; set; }
        [DataMember]
        public GeoLocation GeoLocation { get; set; }
        [DataMember]
        public double Mass { get; set; }
        [DataMember]
        public string NameType { get; set; }
        [DataMember]
        public string RecClass { get; set; }
        [DataMember]
        public double RecLAT { get; set; }
        [DataMember]
        public double RecLONG { get; set; }
        [DataMember]
        public DateTime Year { get; set; }
    }
}
