using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ServiceRequest.Data.Providers
{
    public class DataProvider : IDataProvider
    {
        List<ServiceRequestDetails> _data = null;

        public DataProvider()
        {
            _data = CollectDataFromFile();
        }        

        public bool DeleteData(Guid requestId)
        {
            throw new NotImplementedException();
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _data;
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

        private List<ServiceRequestDetails> CollectDataFromFile()
        {
           var data = JsonConvert.DeserializeObject< List<ServiceRequestDetails>>(File.ReadAllText(@"E:\SH\Practice\ServiceRequest.Api\ServiceRequest.Data\DB\data.json"));
            return data;
        }
    }
}
