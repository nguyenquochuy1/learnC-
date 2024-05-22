namespace EmployeeService
{
    class EmployeeService
    {
        private EmployeeRepository employeeRepository = new();

        public void AddEmployee(Employee employee)
        {
            employeeRepository.Add(employee);
        }

        public bool RemoveEmployee(string id)
        {
            return employeeRepository.Remove(id);
        }

        public bool UpdateEmployee(Employee updatedEmployee)
        {
            return employeeRepository.Update(updatedEmployee);
        }

        public List<Employee> GetEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(string id)
        {
            return employeeRepository.GetById(id);
        }

        public List<Employee> SearchEmployeesByName(string name)
    {
        return employeeRepository.SearchByName(name);
    }
    }
}