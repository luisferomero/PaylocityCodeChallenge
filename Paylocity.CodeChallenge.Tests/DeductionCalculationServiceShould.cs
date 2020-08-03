using System;
using System.Collections.Generic;
using Paylocity.CodeChallenge.BusinessLogic.Services;
using Paylocity.CodeChallenge.Entities.Entities;
using Paylocity.CodeChallenge.Utils.Enums;
using Xunit;

namespace Paylocity.CodeChallenge.Tests
{
    public class DeductionCalculationServiceShould
    {
        [Fact]
        public void DiscountTenPercentIfPersonNameStartWithA()
        {
            var testPerson = new Employee() { Name = "Alex", CostOfBenefits = 1000 };
            var sut = new DeductionCalculationService();
            var anualDeduction = sut.CalculateAnualDeduction(testPerson);

            Assert.Equal(900, anualDeduction);
        }

        [Fact]
        public void NotDiscountIfPersonNameDoesntStartWithA()
        {
            var testPerson = new Employee() { Name = "Joe", CostOfBenefits = 1000 };
            var sut = new DeductionCalculationService();
            var anualDeduction = sut.CalculateAnualDeduction(testPerson);

            Assert.Equal(1000, anualDeduction);
        }

        [Fact]
        public void CalculateAnualDeductionForEmployee()
        {
            var testEmployee = new Employee()
            {
                Name = "Alex",
                CostOfBenefits = 1000,
                Dependents = new List<Dependent>()
                    {
                        new Dependent()
                        {
                            Name = "Megan",
                            CostOfBenefits = 500,
                            DependentType = DependentType.Spouse
                        },
                        new Dependent()
                        {
                            Name = "Mike",
                            CostOfBenefits = 500,
                            DependentType = DependentType.Child
                        }
                    }
            };
            var sut = new DeductionCalculationService();
            var anualDeduction = sut.CalculateTotalAnualDeduction(testEmployee);

            Assert.Equal(1900, anualDeduction);
        }

        [Fact]
        public void CalculatePaycheckDeduction()
        {
            var testEmployee = new Employee()
            {
                Name = "Alex",
                CostOfBenefits = 1000,
                Dependents = new List<Dependent>()
                    {
                        new Dependent()
                        {
                            Name = "Megan",
                            CostOfBenefits = 500,
                            DependentType = DependentType.Spouse
                        },
                        new Dependent()
                        {
                            Name = "Mike",
                            CostOfBenefits = 500,
                            DependentType = DependentType.Child
                        }
                    }
            };
            var sut = new DeductionCalculationService();
            var paycheckdeduction = sut.CalculatePaycheckDeduction(testEmployee);

            Assert.Equal(73.08M, paycheckdeduction);
        }

    }
}
