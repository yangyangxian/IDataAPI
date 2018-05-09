using System;
using System.Collections.Generic;

namespace IDataAPI.Models
{
    public partial class DistrictLevel
    {
        public int DistrictLevelId { get; set; }
        public string DistrictLevelName { get; set; }
        public int? DistrictLevelCode { get; set; }
    }
}
