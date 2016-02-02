using System;
using NUnit.Framework;

namespace CSharp.CustomerOrder.Tests
{
    [TestFixture()]
    public class CustomerIdentityFixture
    {
        const string validFirstName = "Jim";

        [Test()]
        public void TwoDifferntCustomersWithTheSameNameAreNotTheSame(){
            var cust1 = Customer.CreateNewCustomer (validFirstName);
            var cust2 = Customer.CreateNewCustomer (validFirstName);
            Assert.IsFalse (cust1.Equals(cust2));
        }

        [Test()]
        public void SameCustomerLoadedTwiceFromDBIsTheSame(){
            var someCustomerId = Guid.NewGuid();
            var cust1 = new Customer (someCustomerId, validFirstName);
            var cust2 = new Customer (someCustomerId, validFirstName);
            Assert.IsTrue (cust1.Equals(cust2));
        }
    }
}

