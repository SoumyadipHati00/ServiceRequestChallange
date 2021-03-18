using Newtonsoft.Json;
using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServiceRequest.Data.Providers
{
    public class MockDataProvider : IDataProvider
    {
        List<ServiceRequestDetails> _data = null;

        public MockDataProvider()
        {
            _data = CollectDataFromFile();
        }

        public bool DeleteData(Guid requestId)
        {
            throw new NotImplementedException();
        }

        public List<ServiceRequestDetails> GetData()
        {
            throw new NotImplementedException();
        }

        public ServiceRequestDetails GetData(Guid requestId)
        {
            throw new NotImplementedException();
        }

        public bool InsertData(List<ServiceRequestDetails> requestList)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(ServiceRequestDetails request)
        {
            throw new NotImplementedException();
        }

        private List<ServiceRequestDetails> CollectDataFromFile()
        {
            var data = JsonConvert.DeserializeObject<List<ServiceRequestDetails>>(File.ReadAllText(@"..\DB\data.json"));
            return data;
        }
    }
}
