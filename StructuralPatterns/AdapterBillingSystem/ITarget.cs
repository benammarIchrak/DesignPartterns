namespace StructuralPatterns.AdapterBillingSystem;

public interface ITarget
{
    void ProcessCompanySalary(string[,] employeesArray);
}