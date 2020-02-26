using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class RemarkInfo
    {
        public int Remark_ID { get; set; }
        public string Remars { get; set; }
        public ICollection<ServiceRequestInfo> ServiceRequestInfo { get; internal set; }
    }
}