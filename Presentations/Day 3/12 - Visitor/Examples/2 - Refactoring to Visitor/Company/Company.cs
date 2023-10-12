using System.Collections.Generic;

namespace Wincubate.VisitorExamples
{
    class Company : IElement
    {
        public IEnumerable<Employee> Employees { get; }
        public IEnumerable<Project> Projects { get; }

        public Company( IEnumerable<Employee> employees, IEnumerable<Project> projects )
        {
            Employees = employees;
            Projects = projects;
        }

        public void Accept( IVisitor visitor )
        {
            foreach (IElement element in Employees )
            {
                element.Accept(visitor);
            }
            foreach (IElement element in Projects)
            {
                element.Accept(visitor);
            }
        }
    }
}