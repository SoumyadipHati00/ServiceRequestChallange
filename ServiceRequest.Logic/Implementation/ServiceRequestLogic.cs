using ServiceRequest.Logic.Contracts;
using ServiceRequest.Data.Contracts;
using System;
using System.Collections.Generic;
using ServiceRequest.Models;

namespace ServiceRequest.Logic.Implementation
{
    public class ServiceRequestLogic : IServiceRequestLogic
    {
        IServiceRequestData _dataContext;

        public ServiceRequestLogic(IServiceRequestData dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteData(Guid requestId)
        {
            return _dataContext.DeleteData(requestId);
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _dataContext.GetData();
        }

        public ServiceRequestDetails GetData(Guid requestId)
        {
            return _dataContext.GetData(requestId);
        }

        public bool InsertData(List<ServiceRequestDetails> requestList)
        {
            return _dataContext.InsertData(requestList);
        }

        public bool UpdateData(ServiceRequestDetails request)
        {
            return _dataContext.UpdateData(request);
        }
    }
}
