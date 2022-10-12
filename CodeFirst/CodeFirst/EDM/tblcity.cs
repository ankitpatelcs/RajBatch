﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.EDM
{
    public class tblcity
    {
        [Key]
        public int city_id { get; set; }
        public string city_name { get; set; }
        public ICollection<tblemployee> tblemployees { get; set; }
    }
}
