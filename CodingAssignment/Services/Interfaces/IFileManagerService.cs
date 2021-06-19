using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingAssignment.Models;

namespace CodingAssignment.Services.Interfaces
{
  public interface IFileManagerService
  {
    /// <summary>
    /// Returns the complete data model 
    /// </summary>
    /// <returns></returns>
    DataFileModel GetData();

    DataModel GetDataById(Guid fileId);

    /// <summary>
    /// Insert new data model 
    /// </summary>
    /// <returns></returns>
    bool Insert(DataModel model);

    /// <summary>
    /// Updates a specific data model using the id as the key
    /// </summary>
    /// <returns></returns>
    bool Update(DataModel model);

    /// <summary>
    /// Deletes a specific data model using the id as the key
    /// </summary>
    /// <returns></returns>
    bool Delete(Guid id);
  }
}
