using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public int ContactCount { get; set; }
        public int ContactPhoneNumberCount { get; set; }
        public DateTime ReportRequestDate { get; set; }
        public ReportStatus ReportStatus { get; set; }
    }
}
