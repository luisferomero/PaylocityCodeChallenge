using System;
using AutoMapper;
using Paylocity.CodeChallenge.API.DTO;
using Paylocity.CodeChallenge.Entities.Entities;

namespace Paylocity.CodeChallenge.API.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Dependent, DependentDto>().ReverseMap();
        }
    }
}
