using System;
using Paylocity.CodeChallenge.Entities.Entities;

namespace Paylocity.CodeChallenge.BusinessLogic.Services.Interfaces
{
    public interface IDeductionCalculationService
    {
        decimal CalculatePaycheckDeduction(Employee employee, int numberOfPaychecks);
        decimal CalculateTotalAnualDeduction(Employee employee);
        decimal CalculateAnualDeduction(IPerson person);
        decimal GetDiscountRate(IPerson person);
    }
}
