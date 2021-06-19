using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodingAssignment.Models;
using CodingAssignment.Services.Interfaces;
using Newtonsoft.Json;

namespace CodingAssignment.Services
{
  public class FileManagerService : IFileManagerService
  {

    public FileManagerService()
    {
    }
    public DataFileModel GetData()
    {
      var data = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));
      return data;
    }

    public DataModel GetDataById(Guid fileId)
    {
      var data = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));
      var datamodel = data.Data.SingleOrDefault(c => c.Id == fileId);
      return datamodel;
    }

    public bool Insert(DataModel model)
    {
      var data = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));
      if (model != null)
      {
        data.Data.Add(model);
      }
      return UpdateFile(data);
    }

    public bool Update(DataModel model)
    {
      var data = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));
      var exists = GetDataById(model.Id) != null;
      if (!exists)
      {
        return false;
      }

      var dataIndex = data.Data.FindIndex(c => c.Id == model.Id);
      data.Data[dataIndex] = model;
      return UpdateFile(data);
    }

    public bool Delete(Guid id)
    {
      var data = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));
      var dataModel = GetDataById(id);
      if (dataModel == null)
      {
        return false;
      }
      var dataIndex = data.Data.FindIndex(c => c.Id == id);
      data.Data.RemoveAt(dataIndex);
      return UpdateFile(data);
    }

    private bool UpdateFile(object data)
    {
      try
      {
        var jsonData = JsonConvert.SerializeObject(data);
        File.WriteAllText("./AppData/DataFile.json", jsonData);
        return true;
      }
      catch (Exception e)
      {
        return false;
      }

    }
  }
}
