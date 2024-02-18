namespace Interfaces
{
    class Program
    {
        //interface new'lenemez!
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);

        }
    }
    interface IPersonManager
    {
        //unimplemented operations 
        void Add();
        void Update();

    }
    // inherits - class -------------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları yazılır..
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları yazılır..
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi");
            }
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
