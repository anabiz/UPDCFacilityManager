using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Enum;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Clusta
    {
        public Clusta()
        {
            Estates = new HashSet<Estate>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Estate> Estates { get; set; }
    }
}
    

