using System;
using System.Net;
using Xunit;
using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using API.Service;
using FluentAssertions;
using Moq;
using Tests.Setup;

namespace Tests
{
    public class LISControllerTests
    {
        [Fact]
        public void PostRquestToAPI_WithEmptyInput_ReturnsBadRequestResult()
        {
            //Arrange

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(""));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync("");

            //Assert
            var result = actionResult.Result as ObjectResult;
            result?.StatusCode.Should().Be((int) HttpStatusCode.BadRequest);
        }

        [Fact]
        public void PostRquestToAPI_APIThrowsException_ReturnsInternalServerErrorResult()
        {
            //Arrange

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(TestCases.testCases[0])).Throws(new Exception());

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(TestCases.testCases[0]);

            //Assert
            var result = actionResult.Result as StatusCodeResult;
            result?.StatusCode.Should().Be((int)HttpStatusCode.InternalServerError);
        }
    }
}
