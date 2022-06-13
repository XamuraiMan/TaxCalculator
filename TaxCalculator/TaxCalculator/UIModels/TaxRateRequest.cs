﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.UIModels
{
    public class TaxRateRequest
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; } = "US";
    }
}
