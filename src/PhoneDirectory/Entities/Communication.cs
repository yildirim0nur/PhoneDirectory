using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Communication
    {
        [Key]
        public int Id { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Context { get; set; }
    }
}
