using System.Globalization;

namespace AdapterLibrary.BillingSystemExample;

public class HRSystemAdapter : ISalaryProcessor
{
    private readonly ThirdPartyBillingSystem thirdPartyBillingSystem;
    
    public HRSystemAdapter()
    {
        thirdPartyBillingSystem = new ThirdPartyBillingSystem();
    }
    
    public void ProcessSalaries(string[,] rawEmployees)
    {
        var employeeForProcessing = PrepareEmployeeForSalaryProcessing(rawEmployees);
        thirdPartyBillingSystem.ProcessSalary(employeeForProcessing);
    }

    private List<Employee> PrepareEmployeeForSalaryProcessing(string[,] rawEmployees)
    {
        var employeesForProcessing = new List<Employee>();

        for (int i = 0; i < rawEmployees.GetLength(0); i++)
        {
            var id = string.Empty;
            var name = string.Empty;
            var salary = string.Empty;

            for (int j = 0; j < rawEmployees.GetLength(1); j++)
            {
                switch (j)
                {
                    case 0:
                        id = rawEmployees[i, j];
                        break;
                    case 1:
                        name = rawEmployees[i, j];
                        break;
                    default:
                        salary = rawEmployees[i, j];
                        break;
                }
            }

            var employee = new Employee()
            {
                Id = int.Parse(id, CultureInfo.InvariantCulture),
                Name = name,
                Salary = Decimal.Parse(salary, CultureInfo.InvariantCulture)
            };
            
            employeesForProcessing.Add(employee);
        }
        
        Console.WriteLine("Adapter converted array of employees to list of employees...");

        return employeesForProcessing;
    }
}