﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TownComparisons.Domain.Entities;
using TownComparisons.Domain.Models;

namespace TownComparisons.MVC.ViewModels.Shared
{
    public class PropertyQueryGroupViewModel
    {
        public string WebServiceName { get; set; }

        public string QueryGroupId { get; set; } // Kpi id if using Kolada

        public string Title { get; set; } // name/title of the query

        public List<PropertyQueryViewModel> Queries { get; set; }


        public PropertyQueryGroupViewModel()
        {
            //Empty
        }
        public PropertyQueryGroupViewModel(PropertyQueryGroup model)
        {
            WebServiceName = model.WebServiceName;
            QueryGroupId = model.QueryGroupId;
            Title = model.Title;
            Queries = model.Queries.Select(q => new PropertyQueryViewModel(q)).ToList();
        }
    }
}