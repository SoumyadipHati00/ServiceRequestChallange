using ServiceRequest.Data.Contracts;
using ServiceRequest.Data.Providers;
using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceRequest.Data.Implementation
{
    public class ServiceRequestData : IServiceRequestData
    {
        IDataProvider _provider;

        public ServiceRequestData(IDataProvider provider)
        {
            _provider = provider;
        }

        public bool DeleteData(Guid requestId)
        {
            return _provider.DeleteData(requestId);
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _provider.GetData();
        }

        public ServiceRequestDetails GetData(Guid requestId)
        {
            return _provider.GetData(requestId);
        }

        public bool InsertData(List<ServiceRequestDetails> requestList)
        {
            return _provider.InsertData(requestList);
        }

        public bool UpdateData(ServiceRequestDetails request)
        {
            return _provider.UpdateData(request);
        }
    }
}
