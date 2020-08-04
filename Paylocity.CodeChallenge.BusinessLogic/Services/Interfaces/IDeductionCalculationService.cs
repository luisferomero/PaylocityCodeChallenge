using System;
using Paylocity.CodeChallenge.Entities.Entities;

namespace Paylocity.CodeChallenge.BusinessLogic.Services.Interfaces
{
    public interface IDeductionCalculationService
    {
        decimal CalculatePaycheckDeduction(Employee employee, int numberOfPaychecks);
        decimal CalculateDependentPaycheckDeduction(Employee employee, int numberOfPaychecks = 26);
        decimal CalculateTotalAnualDeduction(Employee employee);
        decimal CalculateDependentsAnualDeduction(Employee employee);
        decimal CalculateAnualDeduction(IPerson person);
        decimal GetDiscountRate(IPerson person);
    }
}
