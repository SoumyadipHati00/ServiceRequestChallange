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
            throw new NotImplementedException();
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _dataContext.GetData();
        }

        public ServiceRequestDetails GetData(Guid requestId)
        {
            throw new NotImplementedException();
        }

        public bool InsertData(List<ServiceRequestDetails> requestList)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(List<ServiceRequestDetails> requestList)
        {
            throw new NotImplementedException();
        }
    }
}
