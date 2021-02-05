using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface new'lenemez
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            IPersonManager internManager = new InternManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Update(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Update(employeeManager);
            projectManager.Add(internManager);
            projectManager.Update(internManager);
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        // interface üyeleri dışarıdan erişilebilir olmalıdır. Bu yüzden dafault publictir.
        void Add();
        void Update();
       
    }

    // Inherits - class
    // Implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");  
        }
        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
