using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class ServiceProvidedBy
    {
        public int SP_ID { get; set; }
        public string spName { get; set; }
        public ICollection<ServiceRequestInfo> ServiceRequestInfo { get; internal set; }
    }
}