internal class Program
{
    private static void Main(string[] args)
    {
        IPersonManager customerManager = new CustomerManager(); // Interface'ler kendini implement eden sınıfın referansını tutabilir
        customerManager.Add(); // Müşteri Eklendi

        IPersonManager employeeManager = new EmployeeManager(); // Interface'ler kendini implement eden sınıfın referansını tutabilir
        employeeManager.Add(); // Personel Eklendi

        CustomerManager customerManager2 = new CustomerManager();
        EmployeeManager employeeManager2 = new EmployeeManager();

        ProjectManager projectManager = new ProjectManager();  // Bu kullanım sayesinde her iki türdeki nesneyi aynı fonksiyona gönderebiliriz
        projectManager.AddToProject(customerManager2); // Müşteri Eklendi
        projectManager.AddToProject(employeeManager2); // Personel Eklendi

        projectManager.AddToProject(new CustomerManager()); // Müşteri Eklendi
        projectManager.AddToProject(new EmployeeManager()); // Personel Eklendi

        projectManager.AddToProject(new InternManager());  // Bu şekilde yeni bir sınıf gelse bile diğer kodlara dokunmadan implement edilebilir
    }

    interface IPersonManager // interface'lerden nesne üretilemez
    {
        // unimplemented operation
        void Add();
        void Update();
    }

    // inherit -> class
    // implement -> interface
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

    class ProjectManager()
    {
        public void AddToProject(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}