﻿using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProductVariationTemplate
    {
        public long ProductVariationTemplateId { get; set; }

        public string ProductDescr { get; set; }
        public ESchoolGrade ESchoolGrade { get; set; }

        public ProductVariationTemplate()
        {

        }

        public ProductVariationTemplate(string productDescr, ESchoolGrade eSchoolGrade)
        {
            ProductDescr = productDescr;
            ESchoolGrade = eSchoolGrade;
        }

       
    }
}
