namespace Wincubate.VisitorExamples;

class Project
{
    public string Name { get; set; } = string.Empty;
    public string ProjectCode { get; set; } = string.Empty;
    public int HoursBudget { get; set; }
    public int HoursWorked { get; set; }
    public ProjectState State { get; set; }
}
