using System;
using System.Collections.Generic;

namespace Paylocity.CodeChallenge.Entities.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public IEnumerable<Dependent> Dependents { get; set; }
    }
}
