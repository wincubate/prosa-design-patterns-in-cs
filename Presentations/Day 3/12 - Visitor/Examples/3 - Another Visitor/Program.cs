using Wincubate.VisitorExamples;

CompanyRepository repository = new();
Company company = repository.Get();

RemainingExpensesVisitor visitor = new();
company.Accept(visitor);

Console.WriteLine($"{visitor.RemainingExpenses:c}");
Console.WriteLine();

Console.WriteLine("Before promotion:");
foreach (Employee employee in company.Employees)
{
    Console.WriteLine(employee);
}
Console.WriteLine();

IVisitor otherVisitor = new PromotionVisitor();
company.Accept(otherVisitor);

Console.WriteLine("After promotion:");
foreach (Employee employee in company.Employees)
{
    Console.WriteLine(employee);
}
