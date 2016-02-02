using System;

namespace CSharp.CustomerOrder
{
    public class Customer
    {
        // :( this is a compromise we have to make for ORMs we shouldn't have to do this... and we should never use it
        public Customer (Guid id, string firstName)
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

            return new Customer(id: Guid.NewGuid(), firstName:firstName);
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

