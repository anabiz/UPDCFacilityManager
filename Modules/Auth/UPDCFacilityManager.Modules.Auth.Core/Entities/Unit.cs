using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Enum;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Unit
    {
        public Unit() 
        {
            Occupants = new HashSet<Occupant>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AllocationStatus { get; set; } = EAllocationStatus.NotAllocated.ToString();
        public string EstateId { get; set; }
        public Estate Estate { get; set;}
        public ICollection<Occupant> Occupants { get; set; }
    }
}
