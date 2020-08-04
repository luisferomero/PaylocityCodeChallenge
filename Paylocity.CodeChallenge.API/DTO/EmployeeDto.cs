using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Paylocity.CodeChallenge.API.DTO
{
    public class EmployeeDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public decimal CostOfBenefits { get; set; }

        public List<DependentDto> Dependents { get; set; }
    }
}
