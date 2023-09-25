using System;
using System.Collections;
using System.Collections.Generic;

namespace Wincubate.FactoryMethodExamples
{
    abstract class Publication : IEnumerable<IPart>
    {
        public string Title { get; }
        public IList<IPart> Parts { get; }

        // This is the "Factory Method"
        abstract protected IList<IPart> CreateParts();

        public Publication( string title )
        {
            Title = title;
            Parts = CreateParts();
        }

        public void Print()
        {
            Console.WriteLine($"{Title.ToUpper()}:{Environment.NewLine}{new string('=', Title.Length)}");

            foreach (IPart part in Parts)
            {
                Console.WriteLine(part);
            }
        }

        #region IEnumerable<IPart> Members

        public IEnumerator<IPart> GetEnumerator()
        {
            return Parts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
