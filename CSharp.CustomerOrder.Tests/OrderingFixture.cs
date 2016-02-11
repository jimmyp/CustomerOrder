using System;
using NUnit.Framework;

namespace CSharp.CustomerOrder.Tests
{
    [TestFixture]
    public class OrderingFixture
    {
        [Test]
        public void CannotAddOrderWithOutstandingBalance(){
            var customer = new Customer (Guid.NewGuid (), "Jim", 100.0m);
            Assert.IsFalse(customer.CanAddOrder ());
        }

        [Test]
        public void CanAddOrderWithNoOutstandingBalance(){
        }

        [Test]
        public void AddOrderWithOutstandingBalanceFails(){
        }

        [Test]
        public void AddOrderWithNoOutstandinBalanceSucceeds(){
        }

        [Test]
        public void CustomerWithOrderWithOutstandingBalanceCannotAddOrder(){
        }

        [Test]
        public void PaymentClearsOutstandingBalanceSoCanAddOrder(){
        }
    }
}

