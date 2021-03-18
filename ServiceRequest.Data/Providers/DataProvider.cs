using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text.Json;

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
           var deleteCount = _data.RemoveAll(data => data.Id == requestId);
            SaveData();
            return deleteCount > 0;
        }

        public List<ServiceRequestDetails> GetData()
        {
            return _data;
        }

        public ServiceRequestDetails GetData(Guid requestId)
        {
            return _data.FirstOrDefault(req => req.Id == requestId);
        }

        public bool InsertData(List<ServiceRequestDetails> requestList)
        {
            bool isSuccess = false;
            if(requestList != null && requestList.Count > 0)
            {
                requestList.ForEach(request =>
                {
                    request.CreatedDate = DateTime.Now;
                    _data.Add(request);
                });
                SaveData();
                isSuccess = true;
            }
            return isSuccess;
        }        

        public bool UpdateData(ServiceRequestDetails request)
        {
            bool isSucess = false;
            var dataFromDb = _data.FirstOrDefault(dt => dt.Id == request.Id);
            if(dataFromDb != null)
            {
                dataFromDb.Description = request.Description;
                dataFromDb.CurrentStatus = request.CurrentStatus;
                dataFromDb.BuildingCode = request.BuildingCode;
                dataFromDb.LastModifiedBy = request.LastModifiedBy;
                dataFromDb.LastModifiedDate = DateTime.Now;
                SaveData();
                isSucess = true;
            }
            return isSucess;
        }

        private List<ServiceRequestDetails> CollectDataFromFile()
        {
           var data = JsonConvert.DeserializeObject< List<ServiceRequestDetails>>(File.ReadAllText(@"E:\SH\Practice\ServiceRequest.Api\ServiceRequest.Data\DB\data.json"));
            return data;
        }

        private void SaveData()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            string json = System.Text.Json.JsonSerializer.Serialize(_data, serializeOptions);
            File.WriteAllText(@"E:\SH\Practice\ServiceRequest.Api\ServiceRequest.Data\DB\data.json", json);
        }
    }
}
