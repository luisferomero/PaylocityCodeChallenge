using System;
using System.Collections.Generic;

namespace Paylocity.CodeChallenge.Entities.Entities
{
    public class Employee : IPerson
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public decimal CostOfBenefits { get; set; }

        public List<Dependent> Dependents { get; set; }
    }
}
