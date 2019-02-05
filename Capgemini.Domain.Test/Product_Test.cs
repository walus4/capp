using System;
using Capgemini.Domain;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Product_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Product_create()
        {
            string name = null;
            string description = It.IsAny<string>();
            decimal price = It.IsAny<decimal>();

            Action testAction = () => new Product(name, description, price);

            testAction.Should().Throw<NullReferenceException>();
        }
    }
}