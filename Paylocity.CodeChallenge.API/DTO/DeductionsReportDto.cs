using System;
namespace Paylocity.CodeChallenge.API.DTO
{
    public class DeductionsReportDto
    {
        public decimal TotalPayCheckDeduction { get; set; }

        public decimal DependentsPayCheckDeduction { get; set; }

        public decimal EmployeePayCheckDeduction { get; set; }

        public decimal EmployeeAnualDeduction { get; set; }

        public decimal DependentsAnualDeduction { get; set; }

        public decimal TotalAnualDeduction { get; set; }

        public decimal EmployeePaycheckAfterDeductions { get; set; }

        public decimal EmployeeAnualPayAfterDeductions { get; set; }
    }
}
