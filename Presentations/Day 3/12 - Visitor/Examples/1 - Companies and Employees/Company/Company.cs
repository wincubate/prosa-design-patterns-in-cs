namespace Wincubate.VisitorExamples;

class Company
{
    public IEnumerable<Employee> Employees { get; }
    public IEnumerable<Project> Projects { get; }

    public Company( IEnumerable<Employee> employees, IEnumerable<Project> projects )
    {
        Employees = employees;
        Projects = projects;
    }
}
