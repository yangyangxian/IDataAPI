using System;
using System.Collections.Generic;

namespace IDataAPI.Models
{
    public partial class District
    {
        public Guid DistrictAreaId { get; set; }
        public int DistrictLevelId { get; set; }
        public Guid DistrictId { get; set; }
        public long Area { get; set; }
        public DateTime? Year { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public string ReferenceSource { get; set; }
    }
}
