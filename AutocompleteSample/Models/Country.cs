using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutocompleteSample.Models
{
    public class Country
    {
        public string name { get; set; }
    }

    public class SampleViewModel
    {
        public List<Country> Countries { get; set; }
    }
}