using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager= new CustomerManager();
            customerManager.add();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        public void add();
        public void update();
      
    }

    class CustomerManager : IPersonManager
    {
        public void add()
        {
            Console.WriteLine("müşteri  eklendi");
        }

        public void update()
        {
            Console.WriteLine("Müşsteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void add()
        {
            Console.WriteLine("çalışan eklendi");
        }

        public void update()
        {
            Console.WriteLine("Çalışan durumu güncellendi");
        }
    }
    class ProjectManager
    {
        public void add()
        {
            Console.WriteLine();
        }
    }
}
