using System;
namespace Paylocity.CodeChallenge.API.DTO
{
    public class DeductionsReportDto
    {
        public decimal TotalPayCheckDeduction { get; set; }

        public decimal DependentsPayCheckDeduction { get; set; }

        public decimal EmployeePayCheckDeduction { get; set; }

        public decimal EmployeeAnnualDeduction { get; set; }

        public decimal DependentsAnnualDeduction { get; set; }

        public decimal TotalAnnualDeduction { get; set; }

        public decimal EmployeePaycheckAfterDeductions { get; set; }

        public decimal EmployeeAnnualPayAfterDeductions { get; set; }
    }
}
