﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDemo.Models.ResponseModel
{
    public class FaqResponse : ResponseBase
    {
        public List<Faq> Result { get; set; }
    }
}
