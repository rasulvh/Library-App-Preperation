﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
    }
}
