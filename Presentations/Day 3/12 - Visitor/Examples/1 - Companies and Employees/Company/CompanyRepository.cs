namespace Wincubate.VisitorExamples;

class CompanyRepository
{
    private readonly Company _company;

    public CompanyRepository()
    {
        _company = new Company(
            new List<Employee>
            {
                new Employee
                {
                    FullName = "Ash",
                    Title = "Savior of Mankind",
                    Level = EmployeeLevel.Lead,
                    Salary = 666_666,
                    StockOptions = 100
                },
                new Employee
                {
                    FullName = "Pablo",
                    Title = "Deadite Slayer",
                    Level = EmployeeLevel.Junior,
                    Salary = 250_000,
                    StockOptions = 50
                },
                new Employee
                {
                    FullName = "Kelly",
                    Title = "Deadite Slayer",
                    Level = EmployeeLevel.Junior,
                    Salary = 125_000,
                    StockOptions = 200
                },
                new Employee
                {
                    FullName = "Ruby",
                    Title = "Kandarian",
                    Level = EmployeeLevel.Senior,
                    Salary = 400_000,
                    StockOptions = 100
                }
            },
            new List<Project>
            {
                new Project
                {
                    Name = "Retrieve the Necronomicon",
                    ProjectCode = "KLAATU",
                    State = ProjectState.InProgress,
                    HoursBudget = 2_000,
                    HoursWorked = 1_880
                },
                new Project
                {
                    Name = "Experience Jacksonville",
                    ProjectCode = "JACKVL",
                    State =  ProjectState.Completed,
                    HoursBudget = 250,
                    HoursWorked = 176
                },
                new Project
                {
                    Name = "Reassemble Pablo",
                    ProjectCode = "REPABL",
                    State = ProjectState.Completed,
                    HoursBudget = 50,
                    HoursWorked = 87
                },
                new Project
                {
                    Name = "Find Kandarian Dagger",
                    ProjectCode = "DAGGER",
                    State = ProjectState.Cancelled,
                    HoursBudget = 100,
                    HoursWorked = 99
                },
                new Project
                {
                    Name = "Retreat to Cabin",
                    ProjectCode = "CABINN",
                    State = ProjectState.Initial,
                    HoursBudget = 200,
                    HoursWorked = 0
                }
            }
        );
    }

    public Company Get() => _company;
}