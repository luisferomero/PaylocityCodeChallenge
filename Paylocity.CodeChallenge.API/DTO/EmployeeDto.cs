using System;
using System.Collections.Generic;

namespace Paylocity.CodeChallenge.API.DTO
{
    public class EmployeeDto
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public decimal CostOfBenefits { get; set; }

        public List<DependentDto> Dependents { get; set; }
    }
}
