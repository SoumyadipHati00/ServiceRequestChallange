using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceRequest.Data.Providers
{
    public interface IDataProvider
    {
        public List<ServiceRequestDetails> GetData();
        public ServiceRequestDetails GetData(Guid requestId);
        public bool InsertData(List<ServiceRequestDetails> requestList);
        public bool UpdateData(List<ServiceRequestDetails> requestList);
        public bool DeleteData(Guid requestId);

    }
}
