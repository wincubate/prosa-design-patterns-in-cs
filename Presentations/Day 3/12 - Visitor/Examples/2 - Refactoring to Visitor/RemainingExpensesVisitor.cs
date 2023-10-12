namespace Wincubate.VisitorExamples;

class RemainingExpensesVisitor : IVisitor
{
    public decimal RemainingExpenses { get; private set; }

    public void Visit(Employee employee)
    {
        RemainingExpenses += 1_880 * employee.StockOptions;
    }

    public void Visit(Project project)
    {
        if (project.State == ProjectState.InProgress && project.HoursWorked < project.HoursBudget)
        {
            RemainingExpenses += 1_095 * (project.HoursBudget - project.HoursWorked);
        }
    }
}
