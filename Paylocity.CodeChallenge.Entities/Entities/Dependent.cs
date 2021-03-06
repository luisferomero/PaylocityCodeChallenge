﻿using System;
using Paylocity.CodeChallenge.Utils.Enums;

namespace Paylocity.CodeChallenge.Entities.Entities
{
    public class Dependent : IPerson
    {
        public string Name { get; set; }

        public decimal CostOfBenefits { get; set; }

        public DependentType DependentType { get; set; }
    }
}
