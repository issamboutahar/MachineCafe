using CafeApplication.Controllers;
using CafeApplication.Web.Models;
using CafeApplication.Service.Service;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace CafeApplication.XUnitTest.Controllers
{

    public class ConsommationControllerTest
    {

        [Fact(DisplayName = "Post Consommation")]
        
        public void PostConsommationTest()
        {

            // Arrange
            var mockService = new Mock<IService>();
            var mockConsommation = new Mock<TypeBoissonViewModel>();
            var mockMapper = new Mock<IMapper>();

            mockConsommation.Setup(c => c.DerniereSelection).Returns(true);
            mockConsommation.Setup(c => c.NombreCuilliere).Returns(3);
            mockConsommation.Setup(c => c.PropreMug).Returns(true);
            mockConsommation.Setup(c => c.TypeBoisson).Returns(TypeBoisson.Chocolat);
            mockConsommation.Setup(c => c.ConsommateurID).Returns(1);

            var controller = new ConsommationController(mockService.Object, mockMapper.Object);
            
            var arrange = controller.Post(mockConsommation.Object) as  OkObjectResult;
            

            // Act



            // Assert
            
            
            Assert.Equal(200, arrange.StatusCode);
        }


        

    }
}
