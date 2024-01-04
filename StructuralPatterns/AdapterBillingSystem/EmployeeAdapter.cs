namespace StructuralPatterns.AdapterBillingSystem;

public class EmployeeAdapter : ITarget
{
    //To use Object Adapter Design Pattern, we need to create an object of ThirdPartyBillingSystem
    private ThirdPartyBillingSystem _thirdPartyBillingSystem = new ThirdPartyBillingSystem();

    //The following will accept the employees in the form of string array
    //Then convert the employee string array to List of Employees
    //After conversation, it will call the Adaptee's Method to Process the Salaries
    public void ProcessCompanySalary(string[,] employeesArray)
    {
        string id = null!;
        string name = null!;
        string designation = null!;
        string salary = null!;

        var listEmployee = new List<Employee>();

        for (var i = 0; i < employeesArray.GetLength(0); i++)
        {
            for (var j = 0; j < employeesArray.GetLength(1); j++)
            {
                switch (j)
                {
                    case 0:
                        id = employeesArray[i, j];
                        break;
                    case 1:
                        name = employeesArray[i, j];
                        break;
                    case 2:
                        designation = employeesArray[i, j];
                        break;
                    default:
                        salary = employeesArray[i, j];
                        break;
                }
            }

            listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
        }

        Console.WriteLine("Adapter converted Array of Employee to List of Employee");
        Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
        _thirdPartyBillingSystem.ProcessSalary(listEmployee);
    }
}