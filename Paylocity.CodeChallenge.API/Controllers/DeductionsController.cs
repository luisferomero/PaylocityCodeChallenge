using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Paylocity.CodeChallenge.API.DTO;
using Paylocity.CodeChallenge.BusinessLogic.Services.Interfaces;
using Paylocity.CodeChallenge.Entities.Entities;

namespace Paylocity.CodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeductionsController : Controller
    {
        public IDeductionCalculationService _deductionCalculationService { get; set; }

        public IMapper _mapper { get; set; }

        public DeductionsController(IDeductionCalculationService deductionCalculationService, IMapper mapper)
        {
            _deductionCalculationService = deductionCalculationService;
            _mapper = mapper;
        }


        // GET: api/deductions
        [HttpPost]
        public ActionResult<DeductionsReportDto> CalculateDeductions([FromBody] EmployeeDto employee)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employeeEntity = _mapper.Map<Employee>(employee);

            var result = new DeductionsReportDto()
            {
                TotalPayCheckDeduction = _deductionCalculationService.CalculatePaycheckDeduction(employeeEntity, 26),

                DependentsPayCheckDeduction = _deductionCalculationService.CalculateDependentPaycheckDeduction(employeeEntity , 26),

                EmployeePayCheckDeduction = _deductionCalculationService.CalculatePaycheckDeduction(employeeEntity, 26),

                EmployeeAnnualDeduction = _deductionCalculationService.CalculateAnualDeduction(employeeEntity),

                DependentsAnnualDeduction = _deductionCalculationService.CalculateDependentsAnualDeduction(employeeEntity),

                TotalAnnualDeduction = _deductionCalculationService.CalculateTotalAnualDeduction(employeeEntity),

                EmployeePaycheckAfterDeductions = (employeeEntity.Salary/26) - _deductionCalculationService.CalculatePaycheckDeduction(employeeEntity, 26),

                EmployeeAnnualPayAfterDeductions = employeeEntity.Salary - _deductionCalculationService.CalculateTotalAnualDeduction(employeeEntity),
            };

            return Ok(result);
        }
    }
}
