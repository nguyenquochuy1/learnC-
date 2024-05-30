public class EmployeeView
{
    public void DisplayEmployee(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"UUID: {employee.UUID},ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }
    }

    public Employee GetEmployeeDetails()
    {
        Employee employee = new();

        Console.Write("Enter Employee Name: ");
        employee.Name = Console.ReadLine() ?? throw new Exception("Enter Employess Name Please");

        Console.Write("Enter Employee Position: ");
        employee.Position = Console.ReadLine() ?? throw new Exception("Enter Employess Position Please");

        Console.Write("Enter Employee Salary: ");
        // employee.Salary = Convert.ToDouble(Console.ReadLine() ?? throw new Exception("Enter Employess Salary Please"));
        employee.Salary = Console.ReadLine() ?? throw new Exception("Enter Employess Salary Please");

        return employee;
    }
    public string GetEmployeeId()
    {
        Console.Write("Enter Employee ID: ");
        return Console.ReadLine() ?? throw new Exception("Enter Employee ID Please");
    }

    public Employee GetUpdatedEmployeeDetails(Employee employee)
    {
        Console.WriteLine($"Current Name: {employee.Name}, enter new name (or press enter to keep current): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName))
        {
            employee.Name = newName;
        }

        Console.WriteLine($"Current Position: {employee.Position}, enter new position (or press enter to keep current): ");
        string newPosition = Console.ReadLine();
        if (!string.IsNullOrEmpty(newPosition))
        {
            employee.Position = newPosition;
        }

        Console.WriteLine($"Current Salary: {employee.Salary}, enter new salary (or press enter to keep current): ");
        string newSalaryInput = Console.ReadLine();
        if (double.TryParse(newSalaryInput, out double newSalary))
        {
            employee.Salary = newSalary.ToString();
        }

        return employee;
    }

    public string GetEmployeeNameForSearch()
    {
        Console.Write("Enter Employee Name to Search: ");
        return Console.ReadLine();
    }

}