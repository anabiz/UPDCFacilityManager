using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Estate
    {
        public Estate() 
        {
            Units= new HashSet<Unit>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Unit> Units { get; set; }
    }
}
