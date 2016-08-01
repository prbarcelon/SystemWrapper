using System;
using System.Diagnostics;
using SystemInterface.Diagnostics;
using SystemInterface.Net;
using SystemWrapper.Diagnostics;
using SystemWrapper.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Rhino.Mocks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SystemWrapper.Tests.Net
{
    [TestClass]
    public class DnsWrapTest
    {
        [Test]
        public void DnsWrapTest_Unit_GetHostName_ShouldReturnHostName_WhenCalled()
        {
            // Arrange
            var expectedHostName = System.Net.Dns.GetHostName();
            var dnsWrap = new DnsWrap();

            // Act
            var actualHostName = dnsWrap.GetHostName();

            // Assert
            Assert.AreEqual(expectedHostName, actualHostName);
        }
    }
}
