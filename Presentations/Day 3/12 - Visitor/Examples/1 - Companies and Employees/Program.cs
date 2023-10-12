using Wincubate.VisitorExamples;

CompanyRepository repository = new();
Company company = repository.Get();

decimal remainingExpenses = 0;
foreach (Employee employee in company.Employees)
{
    remainingExpenses += 1_880 * employee.StockOptions;
}
foreach (Project project in company.Projects)
{
    if (project.State == ProjectState.InProgress && project.HoursWorked < project.HoursBudget)
    {
        remainingExpenses += 1_095 * (project.HoursBudget - project.HoursWorked);
    }
}

Console.WriteLine($"{remainingExpenses:c}");
