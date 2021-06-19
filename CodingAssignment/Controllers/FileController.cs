using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingAssignment.Contracts.V1;
using CodingAssignment.Models;
using CodingAssignment.Services;
using CodingAssignment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingAssignment.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class FileController : ControllerBase
  {

    private IFileManagerService _fileManger;

    public FileController(IFileManagerService fileManger)
    {
      _fileManger = fileManger;
    }

    [HttpGet(ApiRoutes.Files.GetAll)]
    public IActionResult Get()
    {
      return Ok(_fileManger.GetData());
    }

    [HttpGet(ApiRoutes.Files.Get)]
    public IActionResult Get([FromRoute] Guid fileId)
    {
      var dataFile = _fileManger.GetDataById(fileId);
      if (dataFile == null)
        return NotFound();

      return Ok(dataFile);
    }

    [HttpPost(ApiRoutes.Files.Create)]
    public IActionResult Post([FromBody]DataModel model)
    {
      model.Id = Guid.NewGuid();
      _fileManger.Insert(model);

      //returns location url
      var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
      var locationUri = baseUrl + "/" +ApiRoutes.Files.Get.Replace("{fileId}", model.Id.ToString());
      return Created(locationUri, model);
    }

    [HttpPut(ApiRoutes.Files.Update)]
    public IActionResult Put([FromBody] DataModel request)
    {
      var model = new DataModel()
      {
        Id = request.Id,
        Values = request.Values
      };
      var updated = _fileManger.Update(model);
      if (updated)
        return Ok(model);

      return NotFound();
    }

    [HttpDelete(ApiRoutes.Files.Delete)]
    public IActionResult Delete([FromRoute] Guid fileId)
    {
      var deleted = _fileManger.Delete(fileId);
      if (deleted)
        return NoContent();
      return NotFound();
    }
  }
}
