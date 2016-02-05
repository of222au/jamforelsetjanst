﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownComparisons.Domain.Entities
{
    public class KpiGroups
    {
        public int Count { get; set; }

        [JsonProperty("values")]
        public List<KpiGroup> Values { get; set; }
    }
}