using Wincubate.VisitorExamples;

CompanyRepository repository = new();
Company company = repository.Get();

RemainingExpensesVisitor visitor = new();
company.Accept(visitor);

Console.WriteLine( $"{visitor.RemainingExpenses:c}" );
