namespace Wincubate.VisitorExamples;

class Employee
{
    public string FullName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public EmployeeLevel Level { get; set; }
    public decimal Salary { get; set; }
    public int StockOptions { get; set; }

    public override string ToString() => $"{FullName} [{Level} {Title}]";
}
