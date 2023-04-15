﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key] //ID to be primary key
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TwitterURL { get; set; }
        public string InstagramURL { get; set; }
        public bool Status { get; set; }
    }
}
