using System;
using System.Collections.Generic;
using System.Linq;
using Paylocity.CodeChallenge.BusinessLogic.Services.Interfaces;
using Paylocity.CodeChallenge.Entities.Entities;
using Paylocity.CodeChallenge.Utils.Constants;

namespace Paylocity.CodeChallenge.BusinessLogic.Services
{
    public class DeductionCalculationService : IDeductionCalculationService
    {
        public decimal CalculatePaycheckDeduction(Employee employee, int numberOfPaychecks = 26)
        {
            return Math.Round(CalculateTotalAnualDeduction(employee) / numberOfPaychecks , 2);
        }

        public decimal CalculateDependentPaycheckDeduction(Employee employee, int numberOfPaychecks = 26)
        {
            return Math.Round(CalculateDependentsAnualDeduction(employee) / numberOfPaychecks, 2);
        }

        public decimal CalculateTotalAnualDeduction(Employee employee)
        {
            return Math.Round(employee.Dependents.Sum(dependent => CalculateAnualDeduction(dependent)) + CalculateAnualDeduction(employee), 2);
        }

        public decimal CalculateDependentsAnualDeduction(Employee employee)
        {
            return Math.Round(employee.Dependents.Sum(dependent => CalculateAnualDeduction(dependent)), 2);
        }

        public decimal CalculateAnualDeduction(IPerson person)
        {
            return Math.Round(person.CostOfBenefits - (person.CostOfBenefits * GetDiscountRate(person)), 2);
        }

        public decimal GetDiscountRate(IPerson person)
        {
            if (person.Name?.ToUpper().StartsWith("A") ?? false)
                return Constants.NAME_START_WITH_A_DISCOUNT_RATE;
            else
                return 0;
        }

    }
}
