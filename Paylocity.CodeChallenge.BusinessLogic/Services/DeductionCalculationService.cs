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
        public decimal CalculatePaycheckDeduction(Employee employee, int numberOfPaychecks)
        {
            return CalculateAnualDeduction(employee) / numberOfPaychecks;
        }

        public decimal CalculateAnualDeduction(Employee employee)
        {
            return employee.Dependents.Sum(dependent => CalculateDeduction(dependent)) + CalculateDeduction(employee);
        }

        public decimal CalculateDeduction(IPerson person)
        {
            return person.CostOfBenefits - (person.CostOfBenefits * GetDiscountRate(person));
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
