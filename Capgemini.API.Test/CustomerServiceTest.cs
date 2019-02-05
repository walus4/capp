using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using System.Linq;
using Capgemini.API.Controllers;
using Capgemini.API.Services;
using Capgemini.Domain;

namespace Capgemini.API.Test
{
    public class CustomerControllerTest
    {
        CustomerController _controller;
        ICustomerService _service;

        public CustomerControllerTest()
        {
            _service = new CustomerServiceFake();
            _controller = new CustomerController(_service);
        }

        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsRightItem()
        {
            // Arrange
            var testGuid = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200");

            // Act
            var okResult = _controller.Get(testGuid).Result; //.Result as OkObjectResult;

            // Assert
            Assert.IsType<Customer>(okResult);
            Assert.Equal(testGuid, (okResult).Id);
        }
    }
}
