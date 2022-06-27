using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Tema_Class
{
    class Customer
    {//struct yra value tipo o klases yra reference
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string EmailAdress { get; set; }
        public string FHomeAdress { get; set; }
        public string WorkAdress { get; set; }

        public static int Counter { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Customer(string firstName, string lastName, string emailAdress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = EmailAdress;
        }
        public bool Validate()
        {
            bool isValid = true;

            if(string.IsNullOrWhiteSpace(FirstName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            return isValid;
        }
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + "" + lastName;

        }
        #region Tipo metodai kurie veikia su duombazem (tipo)

        public bool save()
        {
            //code that saves defined customer
            return true;
        }
        public Customer RetriveById(int id)
        { 
        //db. Customer.SingleOrDefault(x=> 
        }
        public List<Customer>();
            {
            return new List<Customer>();
            }
    #endregion
}
}
