namespace CovarianceContravarianceAndRecords;

internal class Program
{
    static void Main(string[] args)
    {
        //Covariance
        ArrayExample();
        ListExample();
        OwnImplementation();

        //Contravariance
        OwnImplementationContravariance();
        IComparerExample();

    }

    private static void IComparerExample()
    {
        IComparer<Hawk> comparer = new TestComparer<Bird>();
    }

    private static void OwnImplementationContravariance()
    {
        //6.
       // Animal<Hawk> animal = new Animal<Bird>();
       
        IAnimal<Hawk> animal = new Animal<Bird>();
    }

    private static void OwnImplementation()
    {
        //5.
        // SuperUser<Employee> superUser = new SuperUser<Admin>();

        IUser<Employee> superUser = new SuperUser<Admin>();
    }

    private static void ListExample()
    {
        //2.
        // List<Employee> list = new List<Admin>();
        //list.Add(new Manager());

        //3.
        IEnumerable<Employee> list2 = new List<Admin>();
    }

    private static void ArrayExample()
    {
        //1.
        //Employee[] employees = new Admin[] { new Admin(), new Admin(), new Admin(), new Admin() };
        //employees[0] = new Manager();

        //foreach (var item in employees)
        //{
        //    Console.WriteLine(item);
        //} 

        //4.
        IEnumerable<Employee> employees2 = new Admin[] { new Admin(), new Admin(), new Admin(), new Admin() };
        // employees2[0] = new Employee();

        foreach (var item in employees2)
        {
            Console.WriteLine(item);
        }
    }
}