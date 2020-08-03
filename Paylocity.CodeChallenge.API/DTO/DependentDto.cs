using System;
using Paylocity.CodeChallenge.Utils.Enums;

namespace Paylocity.CodeChallenge.API.DTO
{
    public class DependentDto
    {
        public string Name { get; set; }

        public decimal CostOfBenefits { get; set; }

        public DependentType DependentType { get; set; }
    }
}
