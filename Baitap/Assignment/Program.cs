// using EmployeeManagementSystem.EmployeeController;

class Program
{
    public static void Main()
    {
        EmployeeController.EmployeeController controller = new();
        while (true)
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Search Employees");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine() ?? throw new Exception("The Choice is missing");

            switch (choice)
            {
                case "1":
                    controller.AddEmployee();
                    break;
                case "2":
                    controller.RemoveEmployee();
                    break;
                case "3":
                    controller.UpdateEmployee();
                    break;
                case "4":
                    controller.DisplayEmployees();
                    break;
                case "5":
                    controller.SearchEmployees();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}