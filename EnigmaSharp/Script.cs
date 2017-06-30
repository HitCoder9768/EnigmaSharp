using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    public class Script
    {
        public string Name { get; private set; }
        public string Contents { get; private set; }

        public void SetName(string PassedName)
        {
            Name = PassedName;
        }
    }
}
