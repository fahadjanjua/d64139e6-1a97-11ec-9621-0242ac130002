using System;
using System.Collections.Generic;
using System.Net;
using Xunit;
using Moq;
using LIS.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using API.Controllers;
using API.Service;
using FluentAssertions;
using LIS.API.Service;

namespace LIS.Tests
{
    public class LISControllerTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var input = Setup.testCases[0];
            var expectedOutput = Setup.testCaseResults[0];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var input = Setup.testCases[1];
            var expectedOutput = Setup.testCaseResults[1];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var input = Setup.testCases[2];
            var expectedOutput = Setup.testCaseResults[2];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            var input = Setup.testCases[3];
            var expectedOutput = Setup.testCaseResults[3];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            var input = Setup.testCases[4];
            var expectedOutput = Setup.testCaseResults[4];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test6()
        {
            //Arrange
            var input = Setup.testCases[5];
            var expectedOutput = Setup.testCaseResults[5];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test7()
        {
            //Arrange
            var input = Setup.testCases[6];
            var expectedOutput = Setup.testCaseResults[6];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test8()
        {
            //Arrange
            var input = Setup.testCases[7];
            var expectedOutput = Setup.testCaseResults[7];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test9()
        {
            //Arrange
            var input = Setup.testCases[8];
            var expectedOutput = Setup.testCaseResults[8];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }
        [Fact]
        public void Test10()
        {
            //Arrange
            var input = Setup.testCases[9];
            var expectedOutput = Setup.testCaseResults[9];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test11()
        {
            //Arrange
            var input = Setup.testCases[10];
            var expectedOutput = Setup.testCaseResults[10];

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(input)).Returns(Task.FromResult(expectedOutput));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync(input);

            //Assert
            var result = actionResult.Result as OkObjectResult;
            Assert.NotNull(result.Value);
            Assert.Equal(expectedOutput, result.Value);
        }

        [Fact]
        public void Test12()
        {
            //Arrange

            var mockService = new Mock<ILISService>();
            mockService.Setup(x => x.FindLIS(""));

            var controller = new LISController(mockService.Object);

            //Act
            var actionResult = controller.PostAsync("");

            //Assert
            var result = actionResult.Result as ObjectResult;
            result.StatusCode.Should().Be((int) HttpStatusCode.BadRequest);
        }
    }
}
