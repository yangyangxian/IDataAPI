using System;
using System.Collections.Generic;

namespace IDataAPI.Models
{
    public partial class Country
    {
        public Guid CountryId { get; set; }
        public int DistrictLevelId { get; set; }
        public string CountryName { get; set; }
        public string CountryFullName { get; set; }
        public int? CapitalCityId { get; set; }
        public int? ContinentId { get; set; }
    }
}
