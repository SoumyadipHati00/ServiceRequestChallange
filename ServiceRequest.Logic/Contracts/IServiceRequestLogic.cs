using ServiceRequest.Models;
using System;
using System.Collections.Generic;

namespace ServiceRequest.Logic.Contracts
{
    public interface IServiceRequestLogic
    {
        public List<ServiceRequestDetails> GetData();
        public ServiceRequestDetails GetData(Guid requestId);
        public bool InsertData(List<ServiceRequestDetails> requestList);
        public bool UpdateData(ServiceRequestDetails request);
        public bool DeleteData(Guid requestId);
    }
}
