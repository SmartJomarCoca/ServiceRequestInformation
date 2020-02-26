using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class TypeOfService
    {
        public int TS_ID { get; set; }
        public string TypeOfServiceProvided { get; set; }

        
        public ICollection<ServiceRequestInfo> ServiceRequestInfo { get; internal set; }
    }
}