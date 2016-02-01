using System;
using NUnit.Framework;

namespace CSharp.CustomerOrder.Tests
{
    [TestFixture()]
    public class CustomerIdentityFixture
    {
        [Test()]
        public void TwoDifferntCustomersWithTheSameNameAreNotTheSame(){
            var validFirstName = "Jim";
            var cust1 = Customer.CreateNewCustomer (validFirstName);
            var cust2 = Customer.CreateNewCustomer (validFirstName);
            Assert.IsTrue (cust1.Equals(cust2));
        }
    }
}

