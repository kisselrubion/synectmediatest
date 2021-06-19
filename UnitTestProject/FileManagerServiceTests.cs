using CodingAssignment.Models;
using CodingAssignment.Services;
using CodingAssignment.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FileManagerServiceTests
    {

        private IFileManagerService _service;

        [TestInitialize]
        public void Init()
        {
            _service = new FileManagerService();
        }

        [TestMethod]
        public void DeserailizeDataTest()
        {
            //Arrange

            //Act
            var res = _service.GetData();

            //Assert
            Assert.IsNotNull(res);

            Assert.IsInstanceOfType(res, typeof(DataFileModel));

        }
    }
}
