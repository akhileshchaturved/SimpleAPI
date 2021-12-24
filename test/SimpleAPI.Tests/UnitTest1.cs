using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController controllerr = new ValuesController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controllerr.Get(1);
            Assert.Equal("anything else", returnValue.Value);
        }

        }
    }

