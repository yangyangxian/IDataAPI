using System;
using System.Collections.Generic;

namespace IDataAPI.Models
{
    public partial class City
    {
        public Guid CityId { get; set; }
        public int DistrictLevelId { get; set; }
        public string CityName { get; set; }
        public string CityFullName { get; set; }
        public Guid CountryId { get; set; }
    }
}
