using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Enum;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Occupant
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UnitId { get; set; }
        public Unit Unit { get; set; }
        public string Code { get; set; }
        public string AccuntStatus { get; set; } = EAccountStatus.Pending.ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
