namespace CovarianceContravarianceAndRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Covariance
            ArrayExample();
            ListExample();
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
}