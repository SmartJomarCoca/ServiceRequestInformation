using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class OfficeDepartment
    {
        public int OD_ID { get; set; }
        public string OfficeDepartmentName { get; set; }
        public ICollection<ServiceRequestInfo> ServiceRequestInfo { get; internal set; }
    }
}