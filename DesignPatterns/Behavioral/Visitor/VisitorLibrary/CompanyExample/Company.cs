using System.Collections.Generic;
using VisitorLibrary.CompanyExample.Elements.Common;
using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample;

public class Company
{
    private readonly List<Employee> employees = new();

    public void Hire(Employee employee)
        => employees.Add(employee);

    public void LayOff(Employee employee)
        => employees.Remove(employee);
    
    public void ReviewEmployeesAtEndOfTheYear(IPerformanceReview performanceReview)
    {
        foreach (var employee in employees)
        {
            employee.Evaluate(performanceReview);
        }
    }
}