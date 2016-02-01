using System;

namespace CSharp.CustomerOrder
{
    public class Customer
    {
        private Customer (string firstName)
        {
            _firstName = firstName;
        }
            
        public static bool CanCreateNewCustomer (string firstName)
        {
            return !string.IsNullOrEmpty (firstName);
        }

        public static Customer CreateNewCustomer(string firstName){
            if (!CanCreateNewCustomer (firstName:firstName))
                throw new DomainValidationException ("New customer must have first name");

            return new Customer(firstName:firstName);
        }

        string _firstName;

        public override bool Equals (object obj)
        {
            if(!(obj is Customer)) return false;

            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode ()
        {
            return _firstName.GetHashCode ();
        }
    }
}

