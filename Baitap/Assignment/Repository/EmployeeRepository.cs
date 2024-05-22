public class EmployeeRepository
{
    private List<Employee> employees = [];


    public static string AutoGenUUID(){
        Guid uuid = Guid.NewGuid();
        Console.WriteLine("GUID: " + uuid.ToString());
        return uuid.ToString();
    }

    public void Add(Employee employee)
    {
        employee.Id = AutoGenUUID();
        employees.Add(employee);
    }

    public bool Remove(string id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employees.Remove(employee);
            return true;
        }
        return false;
    }

    public bool Update(Employee updatedEmployee)
    {
        var employee = employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);
        if (employee != null)
        {
            employee.Name = updatedEmployee.Name;
            employee.Position = updatedEmployee.Position;
            employee.Salary = updatedEmployee.Salary;
            return true;
        }
        return false;
    }

    public List<Employee> GetAllEmployees()
    {
        return employees;
    }

    public Employee GetById(string id)
    {
        return employees.FirstOrDefault(e => e.Id == id!);
    }

    public List<Employee> SearchByName(string name){
        return employees.Where(e => e.Name.Contains(name,StringComparison.OrdinalIgnoreCase)).ToList();    
    }
}