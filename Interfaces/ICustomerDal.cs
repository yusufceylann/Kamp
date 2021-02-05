using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }
    }

    class OracleServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("ORACLE Added");
        }

        public void Delete()
        {
            Console.WriteLine("ORACLE Deleted");
        }

        public void Update()
        {
            Console.WriteLine("ORACLE Updated");
        }
    }
    class MySqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
