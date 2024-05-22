namespace EmployeeController
{
    public class EmployeeController
    {

        private readonly EmployeeService.EmployeeService service = new();
        private readonly EmployeeView view = new();

        public void AddEmployee()
        {
            Employee employee = view.GetEmployeeDetails();
            service.AddEmployee(employee);
            Console.WriteLine("Employee added successfully.");
        }

        public void RemoveEmployee()
        {
            var id = view.GetEmployeeId();
            bool success = service.RemoveEmployee(id);
            if (success)
            {
                Console.WriteLine("Employee removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void UpdateEmployee()
        {
            var id = view.GetEmployeeId();
            Employee employee = service.GetEmployeeById(id);
            if (employee != null)
            {
                employee = view.GetUpdatedEmployeeDetails(employee);
                service.UpdateEmployee(employee);
                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void DisplayEmployees()
        {
            List<Employee> employees = service.GetEmployees();
            view.DisplayEmployee(employees);
        }

        public void SearchEmployees()
        {
            string name = view.GetEmployeeNameForSearch();
            List<Employee> employees = service.SearchEmployeesByName(name);
            view.DisplayEmployee(employees);
        }

    }

}