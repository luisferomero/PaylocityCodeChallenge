using System;
namespace Paylocity.CodeChallenge.Entities.Entities
{
    public interface IPerson
    {
        public string Name { get; set; }

        public decimal CostOfBenefits { get; set; }
    }
}
