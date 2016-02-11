using System;

namespace CSharp.CustomerOrder
{
    public class Customer
    {
        protected Customer (Guid id, string firstName, decimal outStandingBalance)
        {
            _id = id;
            _firstName = firstName;
        }
            
        public static bool CanCreateNewCustomer (string firstName)
        {
            return !string.IsNullOrEmpty (firstName);
        }

        public static Customer CreateNewCustomer(string firstName){
            if (!CanCreateNewCustomer (firstName:firstName))
                throw new DomainValidationException ("New customer must have first name");

            return new Customer(id: Guid.NewGuid(), firstName:firstName, outStandingBalance: 0.0m);
        }

        public void CanAddOrder (object par)
        {
            throw new NotImplementedException ();
        }

        Guid _id;
        string _firstName;

        public override bool Equals (object obj)
        {
            if(!(obj is Customer)) return false;

            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode ()
        {
            return Tuple.Create (_id, _firstName).GetHashCode ();
        }
    }
}

