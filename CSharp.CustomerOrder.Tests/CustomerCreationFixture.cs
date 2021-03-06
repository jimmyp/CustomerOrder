﻿using NUnit.Framework;
using System;

namespace CSharp.CustomerOrder.Tests
{
    [TestFixture ()]
    public class CustomerCreationFixture
    {
        const string validFirstName = "firstName";

        private void TestCreateCustomerFailsWith(string firstName){
            Assert.Throws<DomainValidationException>(() => Customer.CreateNewCustomer(firstName));
        }

        [Test()]
        public void CannotCreateCustomerWithNullName(){
            TestCreateCustomerFailsWith (null);
        }

        [Test()]
        public void CannotCreateCustomerWithEmptyName(){
            TestCreateCustomerFailsWith (string.Empty);
        }

        [Test()]
        public void CanCreateCustomerWithName(){
            var c = Customer.CreateNewCustomer (firstName: validFirstName);
            Assert.IsNotNull (c);
        }

        private void TestFailingValidationWith(string firstName){
            Assert.IsFalse(Customer.CanCreateNewCustomer(firstName));
        }

        [Test()]
        public void EmptyCustomerNameFailsValidation(){
            TestFailingValidationWith (String.Empty);
        }

        [Test()]
        public void NullCustomerNameFailsValidation(){
            TestFailingValidationWith (null);
        }

        [Test()]
        public void SomeCustomerNamePassesValidation(){
            Assert.IsTrue(Customer.CanCreateNewCustomer(validFirstName));
        }
    }
}

