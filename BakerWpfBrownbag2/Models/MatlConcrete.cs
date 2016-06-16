using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerWpfBrownbag.Models
{
    class MatlConcrete
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double CompressiveStrength28 { get; set; }
        public double InitialCompressiveStrength { get; set; }
        public double CoeffThermalExpansion { get; set; }
        public double DensityDeadLoad { get; set; }
    }
}
