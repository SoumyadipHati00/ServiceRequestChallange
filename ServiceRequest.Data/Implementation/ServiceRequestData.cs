﻿using ServiceRequest.Data.Contracts;
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
            throw new NotImplementedException();
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _provider.GetData();
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
