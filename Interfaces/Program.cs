using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            Demo();
            Demo1();
            Demo2();

            Console.ReadLine();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerDal(),
                new OracleServerDal(),
                new MySqlServerDal()
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerDal());
        }

        private static void Demo1()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerDal());
        }
        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new MySqlServerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };


            ;
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };

            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson //soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson //somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
