using System;
using System.Collections.Generic;
using Capgemini.Domain;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Customer_create()
        {

            string firstName = null;
            string lastName = It.IsAny<string>(); 
            string city = It.IsAny<string>(); 
            string postalCode = It.IsAny<string>();
            string street = It.IsAny<string>();
            string hauseNo = It.IsAny<string>();
            string appartamentNo = It.IsAny<string>();
            string companyName = It.IsAny<string>();
            string nip = "526-11-84-467";

            Action testAction = () => new Customer(firstName, lastName, city,postalCode,street,hauseNo,appartamentNo,companyName,nip);

            testAction.Should().Throw<ArgumentNullException>();
        }
    }
}