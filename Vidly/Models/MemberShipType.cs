﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public short Signupfree { get; set; }
        public byte  DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public byte Id { get; set; }

        public string  Name { get; set; }
    }
}