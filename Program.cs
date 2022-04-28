using System;
using System.Collections.Generic;

namespace CustomerList
{
    class CustomerList
    {

        private string _fname, _lname, _phonenum, _streetaddress, _city, _state;

        public CustomerList(string fname, string lname, string phonenum, string streetaddress, string city, string state)
        {
            _fname = fname;
            _lname = lname;
            _phonenum = phonenum;
            _streetaddress = streetaddress;
            _city = city;
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetFName(string fname)
        {
            _fname = fname;
        }

        public void SetLName(string lname)
        {
            _lname = lname;
        }

        public void SetPhoneNum(string phonenum)
        {
            _phonenum = phonenum;
        }

        public void SetStreetAddress(string streetaddress)
        {
            _streetaddress = streetaddress;
        }

        public void SetCity(string city)
        {
            _city = city;
        }

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetFName()
        {
            return _fname;
        }

        public string GetLName()
        {
            return _lname;
        }

        public string GetPhoneNum()
        {
            return _phonenum;
        }

        public string GetStreetAddress()
        {
            return _streetaddress;
        }

        public string GetCity()
        {
            return _city;
        }

        public static void Customers()
        {
            Console.WriteLine("What do want to do?");
            Console.WriteLine("<---------------------->");
            Console.WriteLine("A. Add a customer!");
            Console.WriteLine("B. Display customers!");
            Console.WriteLine("C. Exit!");
            Console.WriteLine("<---------------------->");
            Console.WriteLine("Make your choice here(Only lower case (a, b, or c): ");
            const string a = "Add a customer!";
            const string b = "Display customers!";
            const string c = "Exit!";
            string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                    AddCustomer();
                    break;
                    case "b":
                    DisplayCustomers();
                    break;
                    case "c":
                    Exit();
                    break;
                }
        }

        public static void AddCustomer()
        {
            List<CustomerList> customerList = new List<CustomerList>();
            Console.WriteLine("<---------------------->");
            Console.WriteLine("First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            string phonenum = Console.ReadLine();
            Console.WriteLine("Street Address: ");
            string streetaddress = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("State: ");
            string state = Console.ReadLine();
            CustomerList customers = new CustomerList(fname, lname, phonenum, streetaddress, city, state);
            customerList.Add(customers);
            Console.WriteLine("<---------------------->");
            Console.WriteLine("Customer List!");
            Console.WriteLine("<---------------------->");
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(phonenum);
            Console.WriteLine(streetaddress + ", " + city + ", " + state);
        }

        public static void DisplayCustomers()
        {
            List<CustomerList> customerList = new List<CustomerList>();
            Console.WriteLine("<---------------------->");
            customerList.ToArray();
            Console.WriteLine(String.Join("\n", customerList));
            Console.WriteLine("<---------------------->");
        }

        public static void Exit()
        {
            Console.WriteLine("Exiting Program Now...!");
            Console.WriteLine("<---------------------->");
            Environment.Exit(0);         
        }

        public static void Main(string[] args)
        {
            Customers();
        }
    }
}
