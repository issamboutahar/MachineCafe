using CafeApplication.Controllers;
using CafeApplication.Service.Service;

using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace CafeApplication.XUnitTest.Controllers
{

    public class ConsommateurControllerTest
    {

        [Fact(DisplayName = "Get All Consommateur")]
        
        public void GetAllTest()
        {

            // Arrange
            var mockService = new Mock<IService>();
            var controller = new ConsommateurController(mockService.Object);
            
            var arrange = controller.Get() as  OkObjectResult;
            var contenantResult = arrange ;

            // Act



            // Assert
            Assert.NotNull(contenantResult);
            Assert.Equal(200, contenantResult.StatusCode);
        }


        [Fact(DisplayName = "Get Consommateur By Id")]
        
        public void GetConsommateurById()
        {

            // Arrange
            var mockService = new Mock<IService>();
            
            var controller = new ConsommateurController(mockService.Object);
            var arrange = controller.Get(1);
            var contenantResult = arrange as OkObjectResult;

            // Act

            

            // Assert

            Assert.Equal(200, contenantResult.StatusCode);
            Assert.NotNull(contenantResult);
        }

    }
}
