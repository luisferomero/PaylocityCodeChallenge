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
        [HttpGet]
        public ActionResult<DeductionsReportDto> Get([FromQuery] EmployeeDto employee)
        {
            var employeeEntity = _mapper.Map<Employee>(employee);
            return Ok();
        }
    }
}
