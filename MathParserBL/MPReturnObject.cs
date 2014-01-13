using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParserBL
{
    public class MPReturnObject
    {

        public bool IsValid { get; set; }
        public decimal Answer { get; set; }
        public string Description { get; set; }
        public string StartingValue { get; set; }
    }
}
