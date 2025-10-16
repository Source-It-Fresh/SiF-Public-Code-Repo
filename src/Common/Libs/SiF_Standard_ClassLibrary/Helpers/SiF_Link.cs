using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceItFresh.Shared.Helpers
{
    public class SiF_Link
    {
        public required string Name { get; set; }
        public required string Url { get; set; }
        public required string Icon { get; set; }
        public List<SiF_Link> NestedLinks { get; set; } = new List<SiF_Link>();
    }
}