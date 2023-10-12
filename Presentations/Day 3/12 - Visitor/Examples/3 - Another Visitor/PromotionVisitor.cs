namespace Wincubate.VisitorExamples;

class PromotionVisitor : IVisitor
{
    public void Visit(Employee employee)
    {
        switch (employee.Level)
        {
            case EmployeeLevel.Junior:
                employee.Level = EmployeeLevel.Senior;
                break;
            case EmployeeLevel.Senior:
                employee.Level = EmployeeLevel.Lead;
                break;
            case EmployeeLevel.Lead:
                employee.Level = EmployeeLevel.Chief;
                break;
            case EmployeeLevel.Chief:
            default:
                break;
        }
    }

    public void Visit(Project project) { }
}
