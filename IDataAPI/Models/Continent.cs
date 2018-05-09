using System;
using System.Collections.Generic;

namespace IDataAPI.Models
{
    public partial class Continent
    {
        public int ContinentId { get; set; }
        public int DistrictLevelId { get; set; }
        public string ContinentName { get; set; }
    }
}
