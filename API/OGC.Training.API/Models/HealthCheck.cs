﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OGC.Training.API.Models
{
    public class HealthCheck
    {
        public string description { get; set; }
        public string status { get; set; }
        public string detail { get; set; }
    }
}