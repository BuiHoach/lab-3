namespace lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employee objects
            Employee emp1 = new Employee
            {
                Id = 1,
                Name = "Alice",
                YearOfBirth = 1990,
                SalaryLevel = 2.5
            };

            Employee emp2 = new Employee
            {
                Id = 2,
                Name = "Bob",
                YearOfBirth = 1985,
                SalaryLevel = 3.2
            };

            // Display employee information
            emp1.Display();
            emp2.Display();

            // Modify basic salary and display again
            Employee.BasicSalary = 3500;
            Console.WriteLine("After updating Basic Salary:");
            emp1.Display();
            emp2.Display();

            // baif 2
            Book book1 = new Book(); // Default constructor
            Book book2 = new Book("George Orwell", 328, "123456789", "1984");

            // Display book information
            book1.DisplayBookInfo();
            book2.DisplayBookInfo();

            // Flip pages forward and backward
            Console.WriteLine("Flipping pages in book2:");
            book2.FlipPageForward();
            book2.DisplayBookInfo();

            book2.FlipPageBackward();
            book2.DisplayBookInfo();

            // Test boundary conditions
            Console.WriteLine("Testing boundary conditions:");
            for (int i = 0; i < 330; i++)
            {
                book2.FlipPageForward();
            }

            book2.FlipPageBackward();
            book2.DisplayBookInfo();
        }
    }
}
