﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownComparisons.Domain.Entities
{
    public class OrganisationalUnit
    {
        public string Id { get; set; }
        public string Municipality { get; set; }
        public string Title { get; set; }
    }
}
