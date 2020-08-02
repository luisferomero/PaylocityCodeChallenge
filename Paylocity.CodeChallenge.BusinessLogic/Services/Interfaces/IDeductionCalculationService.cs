using System;
using Paylocity.CodeChallenge.Entities.Entities;

namespace Paylocity.CodeChallenge.BusinessLogic.Services.Interfaces
{
    public interface IDeductionCalculationService
    {
        decimal CalculatePaycheckDeduction(Employee employee, int numberOfPaychecks);
        decimal CalculateAnualDeduction(Employee employee);
        decimal CalculateDeduction(IPerson person);
        decimal GetDiscountRate(IPerson person);
    }
}
